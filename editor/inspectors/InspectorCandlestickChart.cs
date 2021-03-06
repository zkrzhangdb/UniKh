/** == InspectorCandlestickChart.cs ==
 *  Author:         bagaking <kinghand@foxmail.com>
 *  CreateTime:     2019/11/08 16:03:08
 *  Copyright:      (C) 2019 - 2029 bagaking, All Rights Reserved
 */

using UniKh.comp.ui;
using UnityEditor;
using UnityEditor.UI;
using UnityEngine;

namespace UniKh.editor {
    [CustomEditor(typeof(KhCandlestickChart), true)]
    [CanEditMultipleObjects]
    public class InspectorCandlestickChart : Editor {
      
        public override void OnInspectorGUI() {
            base.OnInspectorGUI(); 
        }
    }
}