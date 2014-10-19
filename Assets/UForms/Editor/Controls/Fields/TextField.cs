﻿using UnityEngine;
using UnityEditor;
using System.Collections;

namespace UForms.Controls.Fields
{
    public class TextField : AbstractField< string >
    {
        public TextField( Vector2 position, Vector2 size, string value = "", string label = "" ) : base( position, size, value, label )
        {

        }

        protected override string DrawAndUpdateValue()
        {
            return EditorGUI.TextField( m_fieldRect, Label, m_cachedValue );
        }

        protected override bool TestValueEquality( string oldval, string newval )
        {
            if ( oldval == null || newval == null )
            {
                if ( oldval == null && newval == null )
                {
                    return true;
                }

                return false;
            }

            return oldval.Equals( newval );
        }
    }
}