wget -nc https://dist.nuget.org/win-x86-commandline/latest/nuget.exe;
mozroots --import --sync
mono nuget.exe install vendor/packages.config -o vendor;
mkdir -p bin;
mcs -sdk:2 -r:vendor/Newtonsoft.Json.7.0.1/lib/net20/Newtonsoft.Json.dll,\
vendor/RestSharp.Net2.1.1.11/lib/net20/RestSharp.Net2.dll,\
System.Runtime.Serialization.dll \
-target:library \
-out:bin/com.knetikcloud.dll \
-recurse:'src/*.cs' \
-doc:bin/com.knetikcloud.xml \
-platform:anycpu
