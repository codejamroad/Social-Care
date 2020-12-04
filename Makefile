MAIN_FILE = Program

#change this to the depth of the project folders
#if needed, add a prefix for a common project folder
CSHARP_SOURCE_FILES = $ /SocialCare/*.cs

#add needed flags to the compilerCSHARP_FLAGS = -out:$(EXECUTABLE)
CSHARP_FLAGS = -out:$(EXECUTABLE)

#change to the environment compiler
CSHARP_COMPILER = mcs

#if needed, change the executable file
EXECUTABLE = $(MAIN_FILE).exe

#if needed, change the remove command according to your system
RM_CMD = -rm -f $(EXECUTABLE)



all: $(EXECUTABLE)

$(EXECUTABLE): $(CSHARP_SOURCE_FILES)
    @ $(CSHARP_COMPILER) $(CSHARP_SOURCE_FILES) $(CSHARP_FLAGS)
    @ echo compiling...

run: all
    ./$(EXECUTABLE)

clean:
    @ $(RM_CMD)

remake:
    @ $(MAKE) clean