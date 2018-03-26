_# BashSoft
Bash-like command interpreter for Windows cmd. Written on C#

Supported commands:

open file in current folder – _open fileName_
make directory in current folder - _mkdir directoryName_
traverse current directory in some depth - _ls depth_
compare content of two files given their absolute path - _cmp path1 path2_
change current directory given a relative path – _changeDirRel relative/path_ or ".." for returning to the previous folder  
change current directory given an absolute path – _changeDir absolutePath_
read students data base from a given file in the current folder – _readDb fileName_
filter students from given course by some criteria and take some of them - _filter courseName excellent/average/poor take 2/10/42/all_
order students from given course ascending/descending and take some of them – _order courseName ascending/descending take 5/17/23/all_
download file – _download urlOfFile_
download file asinchronously – _downloadAsynch urlOfFile =_
get help – _help_ 
