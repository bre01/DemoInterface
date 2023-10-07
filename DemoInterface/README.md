先写出一堆接口，
然后安装这个两个extension
![Alt text](image-1.png)
![Alt text](image-5.png)
注意CSharp to plantUML 要求.net core runtime
可以直接到官网下载
https://dotnet.microsoft.com/en-us/download


然后到接口的那个文件的界面按F1，
然后选择这个PlanteUML: Class-diagram
![](image-2.png)

然后打开这个生成的Plantuml文件夹
中的相应的 .puml文件

![Alt text](image-3.png)

在MacOs下如果不能preview 
需要在puml文件的第二行加入这个代码 
```
!pragma layout smetana
```

![Alt text](image-4.png)


然后点击右上角的preview，即可展示接口
