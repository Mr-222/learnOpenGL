# learnOpenGL
openGL学习记录，包含了**ssao**和**pbr**这两章的内容
***
### 教程链接  
> https://learnopengl.com/Introduction     
  
> https://learnopengl-cn.github.io

### 环境要求  
visual studio2019或更新版本的visual studio

### 文件结构
```
src
├─ pbr
│    ├─ background.fs
│    ├─ background.vs
│    ├─ brdf.fs
│    ├─ brdf.vs
│    ├─ cubemap.vs
│    ├─ equirectangular_to_cubemap.fs
│    ├─ irradiance_convolution.fs
│    ├─ pbr.cpp
│    ├─ pbr.fs
│    ├─ pbr.vs
│    └─ prefilterShader.fs
└─ ssao
       ├─ ssao.cpp
       ├─ ssao.fs
       ├─ ssao.vs
       ├─ ssao_blur.fs
       ├─ ssao_geometry.fs
       ├─ ssao_geometry.vs
       └─ ssao_lighting.fs
```

### 运行
安装好visual studio2019后双击learn1.sln,即可打开工程

### 实际效果
![ssao](/learn1/pic/ssao.png "ssao")
***
![ssao](/learn1/pic/pbr.png "pbr")

