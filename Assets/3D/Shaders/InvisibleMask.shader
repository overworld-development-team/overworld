Shader "Custom/InvisibleMask" {
  SubShader {
    Tags { "Queue"="Geometry+1" }
    Pass {
      Blend Zero One
    }
  } 
}

//just a simple invisible shader for covering up the monitor rendering