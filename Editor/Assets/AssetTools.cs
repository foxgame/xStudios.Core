using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;

namespace X
{
    public class AssetTools
    {
        static string path = "Assets/xStudios/Assets/AssetSetting.asset";


        public static AssetSetting LoadSetting()
        {
            AssetSetting assetSetting = AssetDatabase.LoadAssetAtPath<AssetSetting>( path );
            return assetSetting;
        }

        [MenuItem( "xStudios/Assets/Setting" )]
        public static void Setting()
        {
            if ( !File.Exists( path ) )
            {
                Directory.CreateDirectory( Path.GetDirectoryName( path ) );

                var asset = ScriptableObject.CreateInstance<AssetSetting>();

                AssetDatabase.CreateAsset( asset , path );
                AssetDatabase.SaveAssets();
                AssetDatabase.Refresh();
            }

            Selection.activeObject = AssetDatabase.LoadMainAssetAtPath( path );
        }

    }

}
