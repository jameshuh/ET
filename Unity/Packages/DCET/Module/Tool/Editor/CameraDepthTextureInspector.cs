using UnityEditor;
using DCET.Model;
using UnityEngine;

namespace DCET.Editor
{
    [CustomEditor(typeof(CameraDepthTexture))]
    public class CameraDepthTextureInspector : UnityEditor.Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            if (target)
            {
                var cameraDepthTexture = target as CameraDepthTexture;

                if (cameraDepthTexture)
                {
                    var camera = cameraDepthTexture.GetComponent<Camera>();

                    if(camera && camera.depthTextureMode != cameraDepthTexture.depthTextureMode)
                    {
                        cameraDepthTexture.Start();
                    }
                }
            }
        }
    }
}