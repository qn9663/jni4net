//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.3074
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace java_.lang {
    
    
    #region Component Designer generated code 
    public unsafe partial class IObject_ {
        
        public static global::java.lang.Class _class {
            get {
                return global::java_.lang.@__IObject.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute(typeof(global::java_.lang.IObject))]
    internal unsafe partial class @__IObject : global::java.lang.Object, global::java_.lang.IObject
    {
        
        new internal static global::java.lang.Class staticClass;
        
        protected @__IObject(global::net.sf.jni4net.jni.JNIEnv env) : 
                base(env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv env, java.lang.Class staticClass) {
            global::java_.lang.@__IObject.staticClass = staticClass;
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv env) {
                return new global::java_.lang.@__IObject(env);
            }
        }
    }
    #endregion
}
