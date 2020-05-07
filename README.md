## 简介

DCET是Unity3D客户端和.Net Core服务器的双端框架。

## DCET与ET的差异

DCET是基于ET4.0、5.0、6.0进行二次开发的分支版本，主要差异如下：

* 移除UGUI模块；
* 新增FGUI模块，包括UI加载、UI管理、UI控件管理代码自动生成插件等完整的FGUI工作流；
* 新增行为树模块，包括可视化编辑器、双端运行时、逻辑全热更的完整的行为树工作流；
* 新增Lua模块，包括CSharp.Lua（自动翻译热更层代码为Lua）、xLua(执行CSharp.Lua翻译的热更层Lua代码)、RapidJson、lua-protobuf、LuaSocket、LPeg、FFI for lua53等完整的Lua热更工作流。
* 将框架模块化，并使用Unity的PackageManager进行管理，可以根据项目需求，按需选择模块引用。同时将框架和游戏业务分离，使维护框架代码更方便。

## 入门

#### 1.搭建环境

​	第一步：下载DCET，下载的方式分为三种：

- 直接下载压缩包，通过下载地址：[`https://github.com/DukeChiang/DCET/archive/dukechiang_master.zip`](https://github.com/DukeChiang/DCET/archive/dukechiang_master.zip)，进行下载。
- 使用Git命令进行下载，通过Git命令行工具，输入：`git clone https://github.com/DukeChiang/DCET.git 目标文件夹(如：D:/WorkSpace/DCET)`，回车即可下载。
- 使用SourceTree等可视化工具进行下载，找到Clone功能，输入源路径：`https://github.com/DukeChiang/DCET.git`，选择目标路径：`D:/WorkSpace/DCET（示例）`，然后点击Clone。如果Clone失败，可以尝试方式2进行下载，然后使用Add功能进行可视化管理。

​	第二步：下载并安装Unity2018.4.12f1，有两种下载方式，根据自己的情况选择一种方式下载，只需要能正常使用相应版本的Unity即可，理论上是支持大多数的Unity的版本的，不过由于Unity版本众多，如果需要在其他版本的Unity中使用，需自行适配。下载地址如下：

- 中国版下载地址：[`https://unity.cn/releases`](https://unity.cn/releases)
- 国际版下载地址：[`https://unity3d.com/get-unity/download/archive`](https://unity3d.com/get-unity/download/archive) (需要科学上网才能下载)

​	第三步：安装VS2019，在安装Unity时，可以选择安装VS2019，或者通过VS官网下载([`https://visualstudio.microsoft.com/zh-hans/thank-you-downloading-visual-studio/?sku=Community&rel=16`](https://visualstudio.microsoft.com/zh-hans/thank-you-downloading-visual-studio/?sku=Community&rel=16))，然后安装的时候选择：.NET桌面开发、使用C++桌面开发、使用Unity的游戏开发(可以去掉Unity编辑器安装)、使用C++的Linux开发、.Net Core跨平台开发。推荐安装以上组件，在DCET开发中都可能用到。

#### 2.运行指南

​	第一步：启动服务器：搭建环境完成之后，打开Server/Server.sln解决方案，点击生成解决方案，如果控制台输出的日志中，所有项目都生成成功，即可点击“Start”启动服务器。如果控制台输出的日志中提示存在生成失败的项目，则很可能是环境不全导致，右键点击“DCET.Init”项目，点击属性，查看目标框架.NET Core 3.0是否正常安装，如果未安装，则需要下载并安装([`https://dotnet.microsoft.com/download`](https://dotnet.microsoft.com/download))，如果安装之后，目标框架依然没有.NET Core 3.0，说明VS版本过低，更新到最新版即可解决。

​	第二步：启动客户端：打开Unity2018.4.12f1，点击Open，选择DCET路径下的Unity目录，点击选择文件夹，即可启动DCET客户端。此时，点击运行按钮，即可成功运行，点击登录，点击进入地图，然后就可以右键点击屏幕，看到骷髅移动的状态同步的官方示例。如果运行中，点击登录提示“System.Exception: Rpc error”，一般情况下是服务器未成功启动，需要检查第一步是否未完成。

#### 3.开发指南

​	为了框架代码维护更方便，且按需引用更方便，现已将框架模块化，并通过Unity的[PackageManager](https://docs.unity3d.com/Packages/com.unity.package-manager-ui@2.0/manual/index.html)和[Assembly Definition](https://docs.unity3d.com/Manual/class-AssemblyDefinitionImporter.html)进行管理，所以相对于ET的目录结构会存在一定的差异，但实际功能几乎没有差别。下文将分别阐述服务器和客户端的开发指南。

- 服务器：服务器代码所在目录为`DCET/Server`，并通过`DCET/Server/Server.sln`解决方案管理所有项目(包括框架和游戏业务)，框架代码所在目录为`DCET/Server/Packages`，具体的项目将在进阶文档中详细介绍。游戏业务代码所在目录为`DCET/Server/Assets`，分为`Init、Runtime、Hotfix、Benchmark`四个项目，其中Init为入口项目，Runtime为非热更项目、Hotfix为热更项目、Benchmark为测试项目，依赖关系为Init→Benchmark→Hotfix→Runtime。

- 客户端：客户代码所在目录为`DCET/Unity`，并通过`DCET/Unity/Unity.sln`解决方案管理所有项目(包括框架和游戏业务)，框架代码所在目录为`DCET/Unity/Packages`，具体的项目将在进阶文档中详细介绍。游戏业务代码所在目录为`DCET/Unity/Assets`，分为`Runtime、Hotfix、Editor`三个项目，其中Runtime为入口项目和非热更项目、Hotfix为热更项目、Editor为编辑器项目，依赖关系为Editor→Hotfix→Runtime，Runtime通过反射或Lua的方式启动Hotfix，所以不需要Runtime依赖Hotfix。

  值得注意的是框架和游戏业务的依赖关系为：**游戏业务→框架**，依赖不当将导致项目混乱，不利于维护。

## 进阶

#### 1.模块概述

#### 2.核心模块

#### 3.下载器模块

#### 4.配置模块

#### 5.网络模块

#### 6.协程锁模块

#### 7.数值模块

#### 8.寻路模块

#### 9.行为树模块

#### 10.FGUI模块

#### 11.Lua模块

## 高级

#### 1.xLua+CSharp.Lua适配原理

## FAQ

待更新

## 技术支持

ET群：474643097

ET官网：[`http://bbs.etframework.net/`](http://bbs.etframework.net/)
