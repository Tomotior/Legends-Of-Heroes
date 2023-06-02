
using UnityEngine;
using System.Collections;
using UnityEditor;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine.Profiling;

namespace ET
{
    //寻找引用
    public class FindReferences
    {
        /// <summary>
        /// 获取Unity Assets文件夹下相对路径
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        static public string GetRelativeAssetsPath(string path)
        {
            return "Assets" + Path.GetFullPath(path).Replace(Path.GetFullPath(Application.dataPath), "").Replace('\\', '/');
        }
    }
}