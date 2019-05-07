using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using SDL2;
using WaveEngine.Bindings.OpenGL;

namespace OpenGLTest
{
    unsafe class Program
    {
        const string vertexShaderSource = @"#version 330 core
                layout (location = 0) in vec3 aPos;
                void main()
                {
                   gl_Position = vec4(aPos.x, aPos.y, aPos.z, 1.0);
                }";

        const string fragmentShaderSource = @"#version 330 core\
                out vec4 FragColor;
                void main()
                {
                   FragColor = vec4(1.0f, 0.5f, 0.2f, 1.0f);
                }";

        static void Main(string[] args)
        {
            SDL.SDL_GL_SetAttribute(SDL.SDL_GLattr.SDL_GL_CONTEXT_MAJOR_VERSION, 2);
            SDL.SDL_GL_SetAttribute(SDL.SDL_GLattr.SDL_GL_CONTEXT_MINOR_VERSION, 1);

            IntPtr window = SDL.SDL_CreateWindow(
                "OpenGL.NET Test",
                SDL.SDL_WINDOWPOS_CENTERED,
                SDL.SDL_WINDOWPOS_CENTERED,
                960,
                540,
                SDL.SDL_WindowFlags.SDL_WINDOW_OPENGL | SDL.SDL_WindowFlags.SDL_WINDOW_SHOWN);

            IntPtr context = SDL.SDL_GL_CreateContext(window);
            SDL.SDL_GL_MakeCurrent(window, context);

            GL.LoadGetString(context, SDL.SDL_GL_GetProcAddress);

            Console.WriteLine("OpenGL Version: {0}", Marshal.PtrToStringAnsi(GL.glGetString(StringName.Version)));

            // Now load the rest of the functions in one go
            GL.LoadAllFunctions(context, SDL.SDL_GL_GetProcAddress);

            uint vertexShader = GL.glCreateShader(ShaderType.VertexShader);

            int nShaders = 1;

            IntPtr* textPtr = stackalloc IntPtr[nShaders];
            var lengthArray = stackalloc int[nShaders];

            lengthArray[0] = vertexShaderSource.Length;
            textPtr[0] = Marshal.StringToHGlobalAnsi(vertexShaderSource);

            GL.glShaderSource(vertexShader, nShaders, (IntPtr)textPtr, new IntPtr(lengthArray));
            GL.glCompileShader(vertexShader);
            // checkErrors
            int success = 0;
            var infoLog = stackalloc char[512];
            lengthArray[0] = success;
            GL.glGetShaderiv(vertexShader, ShaderParameterName.CompileStatus, new IntPtr(lengthArray));
            if (success > 0)
            {
                GL.glGetShaderInfoLog(vertexShader, 512, IntPtr.Zero, new IntPtr(infoLog));
                Console.WriteLine($"Error: shader vertex compilation failed: {new string(infoLog)}");
            }

            uint fragmentShader = GL.glCreateShader(ShaderType.FragmentShader);

            lengthArray[0] = fragmentShaderSource.Length;
            textPtr[0] = Marshal.StringToHGlobalAnsi(fragmentShaderSource);
            GL.glShaderSource(fragmentShader, 1, (IntPtr)textPtr, new IntPtr(lengthArray));
            GL.glCompileShader(fragmentShader);
            // checkErrors
            lengthArray[0] = success;
            GL.glGetShaderiv(fragmentShader, ShaderParameterName.CompileStatus, new IntPtr(lengthArray));
            if (success > 0)
            {
                GL.glGetShaderInfoLog(fragmentShader, 512, IntPtr.Zero, new IntPtr(infoLog));
                Console.WriteLine($"Error: shader fragment compilation failed: {new string(infoLog)}");
            }

            uint shaderProgram = GL.glCreateProgram();
            GL.glAttachShader(shaderProgram, vertexShader);
            GL.glAttachShader(shaderProgram, fragmentShader);
            GL.glLinkProgram(shaderProgram);
            // checkErrors
            lengthArray[0] = success;
            GL.glGetProgramiv(shaderProgram, ProgramPropertyARB.LinkStatus, new IntPtr(lengthArray));
            if (success > 0)
            {
                GL.glGetProgramInfoLog(shaderProgram, 512, IntPtr.Zero, new IntPtr(infoLog));
                Console.WriteLine($"Error: shader program compilation failed: {new string(infoLog)}");
            }

            GL.glDeleteShader(vertexShader);
            GL.glDeleteShader(fragmentShader);


            float[] vertices = {
                -0.5f, -0.5f, 0.0f,
                0.5f, -0.5f, 0.0f,
                0.0f,  0.5f, 0.0f,
            };

            uint VBO = 0;
            uint VAO = 0;
            GL.glGenVertexArrays(1, new IntPtr(VAO));
            GL.glGenBuffers(1, new IntPtr(VBO));

            GL.glBindVertexArray(VAO);
            GL.glBindBuffer(BufferTargetARB.ArrayBuffer, VBO);
            GL.glBufferData(BufferTargetARB.ArrayBuffer, vertices.Length, IntPtr.Zero, BufferUsageARB.StaticDraw);

            GL.glVertexAttribPointer(0, 3, VertexAttribPointerType.Float, false, sizeof(float), IntPtr.Zero);
            GL.glBindBuffer(BufferTargetARB.ArrayBuffer, 0);

            GL.glBindVertexArray(0);

            bool running = true;
            while (running)
            {
                SDL.SDL_Event evt;
                while (SDL.SDL_PollEvent(out evt) != 0)
                {
                    if (evt.type == SDL.SDL_EventType.SDL_QUIT)
                    {
                        running = false;
                    }
                }

                GL.glClearColor(0f, 0f, 0f, 1f);
                GL.glClear((uint)AttribMask.ColorBufferBit);

                GL.glUseProgram(shaderProgram);
                GL.glBindVertexArray(VAO);
                GL.glDrawArrays(PrimitiveType.Triangles, 0, 3);

                ///GL.glFlush();

                SDL.SDL_GL_SwapWindow(window);
            }

            ////GL.glDeleteVertexArrays(1, new IntPtr(VAO));
            ////GL.glDeleteBuffers(1, new IntPtr(VBO));

            SDL.SDL_DestroyWindow(window);
        }
    }
}
