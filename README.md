# C# -> C Interop Test

Identifying an issue when passing complex parameters to C from C# when running on MacOS (M1) architecture.

## Preface
When passing complex parameters from C# to C, it appears under certain conditions that memory alignment and padding issues may arise when 
combined with Apple's M1 (arm) architecture.

The test included in this repo is intended to showcase this issue. InteropTest will pass several parameters to a compiled C library, which
will sum the numbers provided and return the sum. InteropTest will then compare the sum against the expected sum. In the event that data looses
accuracy through interop, the total sum of the numbers will no longer match, and the test will fail.

Additionally, the test will print sent and received values for all numbers to allow for manual inspection in the event of a test failure.

## To Test
### On MacOS with M1 Architecture
1. Run the `dotnet build` command to build the InteropTest project.
2. Copy the `clib.dylib` from the clib directory to the bin directory of the InteropTest project.
3. Run the InteropTest `./InteropTest`.

### On Linux with x64 Architecture
1. Run the `dotnet build` command to build the InteropTest project.
2. Copy the `clib.so` from the clib directory to the bin directory of the InteropTest project.
3. Run the InteropTest `./InteropTest`.

### On Other OS/Architecture
1. Run the `dotnet build` command to build the InteropTest project.
2. Compile the `clib.c` using gcc to generate a shared library. The arguments for gcc may vary by OS and architecture. **It is important that the shared library be named `clib` and be given the appropriate extension.**
3. Copy the compiled shared library from step 2 from the clib directory to the bin directory of the InteropTest project.
4. Run the InteropTest `./InteropTest`.