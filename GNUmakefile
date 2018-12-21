all: SMAFS.ex5

SMAFS.ex5: SMAFS.mq5 SMAFS.dll
	-metaeditor64.exe /compile:SMAFS.mq5 /log:log.log
	cat log.log
	rm log.log

SMAFS.dll: SMAFS/bin/Debug/netstandard2.0/SMAFS.dll
	cp SMAFS/bin/Debug/netstandard2.0/SMAFS.dll .

clean:
	-rm SMAFS.ex5
	-rm SMAFS.dll
