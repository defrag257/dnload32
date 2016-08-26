#按32位运行.NET程序

用法：dnload32\bin\x86\Debug\dnload32 filename.exe [args]

要点：

1. 用AppDomain.CurrentDomain.ExecuteAssembly执行程序集
2. 将解决方案平台设为x86（而不是Any）

