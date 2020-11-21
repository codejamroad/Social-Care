# This is make file for c#
#all:

#compile:
# mcs *.cs -out:multiplefiles.exe
# mcs Project.cs Class1.cs -out:multiplefiles.exe

#run:
# mono multiplefiles.exe test.txt
 
compiler=mcs
runner=mono

all:multiplefiles.exe

multiplefiles.exe:*.cs
# mcs *.cs -out:multiplefiles.exe
 $(compiler) *.cs -out:multiplefiles.exe
run:all
# mono multiplefiles.exe test.txt
 $(runner) multiplefiles.exe test.txt
clean:
 rm multiplefiles.exe test.txt.out