- 入门
    1. 搭建环境
           第一步：下载DCET，下载的方式分为三种：
           1：直接下载压缩包，可以通过DCET的Github下载地址(https://github.com/DukeChiang/DCET/archive/dukechiang_master.zip)点击下载。
           2：使用Git命令进行下载，通过Git命令行工具，输入：git clone https://github.com/DukeChiang/DCET.git 目标文件夹(如：D:/WorkSpace/DCET)，回车即可下载。
           3：使用SourceTree等可视化工具进行下载，找到Clone功能，输入源路径：https://github.com/DukeChiang/DCET.git，选择目标路径：D:/WorkSpace/DCET（示例），然后点击Clone。如果Clone失败，可以尝试方式2进行下载，然后使用Add功能进行可视化管理。
<!--more-->
           第二步：下载并安装Unity2018.4.12f1，有两种下载方式，根据自己的情况选择一种方式下载，只需要能正常使用相应版本的Unity即可，理论上是支持大多数的Unity的版本的，不过由于Unity版本众多，如果需要在其他版本的Unity中使用，需自行适配。下载地址如下：
           1.中国版下载地址：https://unity.cn/releases
           2.国际版下载地址：https://unity3d.com/get-unity/download/archive(需要科学上网才能下载)
<!--more-->
           第三步：安装VS2019，在安装Unity时，可以选择安装VS2019，或者通过VS官网下载(https://visualstudio.microsoft.com/zh-hans/thank-you-downloading-visual-studio/?sku=Community&rel=16)，然后安装的时候选择：.NET桌面开发、使用C++桌面开发、使用Unity的游戏开发(可以去掉Unity编辑器安装)、使用C++的Linux开发、.Net Core跨平台开发。推荐安装以上组件，在DCET开发中都可能用到。
    2. 运行指南
           第一步：启动服务器：搭建环境完成之后，打开Server/Server.sln解决方案，点击生成解决方案，如果控制台输出的日志中，所有项目都生成成功，即可点击“Start”启动服务器。如果控制台输出的日志中提示存在生成失败的项目，则很可能是环境不全导致，右键点击“DCET.Init”项目查看目标框架.NET Core 3.0是否正常安装，如果未安装，则需要下载并安装https://dotnet.microsoft.com/download，如果安装之后，目标框架依然没有.NET Core 3.0，说明VS版本过低，更新到最新版即可解决。
<!--more-->
           第二步：启动客户端：打开Unity2018.4.12f1，点击Open，选择DCET路径下的Unity目录，点击选择文件夹，即可启动DCET客户端。此时，点击运行按钮，即可成功运行，点击登录，点击进入地图，然后就可以右键点击屏幕，看到骷髅移动的状态同步的官方示例。如果运行中，点击登录提示“System.Exception: Rpc error”，一般情况下是服务器未成功启动，需要检查第一步是否未完成。
    3. 开发指南
- 进阶
    1. 模块概述
    2. 核心模块
    3. 下载器模块
    4. 配置模块
    5. 网络模块
    6. 协程锁模块
    7. 数值模块
    8. 寻路模块
    9. 行为树模块
    10. FGUI模块
    11. Lua模块
- 高级
    1. xLua+CSharp.Lua适配原理