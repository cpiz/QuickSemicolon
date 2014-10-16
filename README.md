QuickSemicolon
==============
VS2013插件for C++/C#，让光标快速跳至行尾并增加分号符（如果需要），结束当前语句

An extention for VisualStudio 2013, allows you to move the caret to the end of line and add a semicolon automatically.

#安装
在bin\Release目录获得QuickSemicolon.vsix，双击进行安装

#使用
启动VS，进入"工具 - 选项 - 配置 - 环境 - 键盘"

设置一个快捷键绑定“工具.QuickSemicolon”命令，OK.

在编写代码过程中，按下设定的快捷键即可。

同时，VS菜单的工具中也增加了一个QuickSemicolon选项。

#其他
如果当前行尾已经存在分号，触发命令后只移动光标

如果当前行是空行，也不起作用