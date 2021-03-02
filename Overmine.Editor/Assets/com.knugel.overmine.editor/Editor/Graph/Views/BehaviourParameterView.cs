using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using GraphProcessor;
using UnityEngine;
using UnityEngine.UIElements;

namespace Editor.Graph.Views
{
    public class BehaviourParameterView : ExposedParameterView
    {
        new const string title = "Variables";
        
        readonly string exposedParameterViewStyle = "ExposedParameterView";

        public BehaviourParameterView()
        {
            var style = Resources.Load<StyleSheet>(exposedParameterViewStyle);
            if (style != null)
                styleSheets.Add(style);
        }

        protected override void Initialize(BaseGraphView graphView)
        {
            base.title = title;
            base.Initialize(graphView);
        }

        protected override IEnumerable<Type> GetExposedParameterTypes()
        {
            return base.GetExposedParameterTypes().Where(x => x.Assembly == Assembly.GetExecutingAssembly());
        }
    }
}