﻿namespace Squalr.Engine.Memory.Windows
{
    using Processes;
    using Squalr.Engine.DataTypes;
    using System;
    using System.Diagnostics;
    using System.Text;

    /// <summary>
    /// Class for memory editing a remote process.
    /// </summary>
    internal class WindowsMemoryWriter : IMemoryWriter
    {
        /// <summary>
        /// A reference to target process.
        /// </summary>
        private Process systemProcess;

        /// <summary>
        /// The chunk size for memory regions. Prevents large allocations.
        /// </summary>
        private const Int32 ChunkSize = 2000000000;

        /// <summary>
        /// Initializes a new instance of the <see cref="WindowsAdapter"/> class.
        /// </summary>
        public WindowsMemoryWriter()
        {
            // Subscribe to process events
            ProcessAdapterFactory.GetProcessAdapter().Subscribe(this);
        }

        /// <summary>
        /// Gets a reference to the target process. This is an optimization to minimize accesses to the Processes component of the Engine.
        /// </summary>
        public Process SystemProcess
        {
            get
            {
                try
                {
                    if (this.systemProcess?.HasExited == true)
                    {
                        this.systemProcess = null;
                    }
                }
                catch
                {
                }

                return this.systemProcess;
            }

            private set
            {
                this.systemProcess = value;
            }
        }

        /// <summary>
        /// Recieves a process update. This is an optimization over grabbing the process from the <see cref="IProcessAdapter"/> component
        /// of the <see cref="EngineCore"/> every time we need it, which would be cumbersome when doing hundreds of thousands of memory read/writes.
        /// </summary>
        /// <param name="process">The newly selected process.</param>
        public void Update(NormalizedProcess process)
        {
            if (process == null)
            {
                // Avoid setter functions
                this.systemProcess = null;
                return;
            }

            try
            {
                this.SystemProcess = Process.GetProcessById(process.ProcessId);
            }
            catch
            {
                // Avoid setter functions
                this.systemProcess = null;
            }
        }

        /// <summary>
        /// Writes a value to memory in the opened process.
        /// </summary>
        /// <param name="elementType">The data type to write.</param>
        /// <param name="address">The address to write to.</param>
        /// <param name="value">The value to write.</param>
        public void Write(DataType elementType, IntPtr address, Object value)
        {
            Byte[] bytes;

            switch (elementType)
            {
                case DataType type when type == DataType.Byte || type == typeof(Boolean):
                    bytes = BitConverter.GetBytes((Byte)value);
                    break;
                case DataType type when type == DataType.SByte:
                    bytes = BitConverter.GetBytes((SByte)value);
                    break;
                case DataType type when type == DataType.Char:
                    bytes = Encoding.UTF8.GetBytes(new Char[] { (Char)value });
                    break;
                case DataType type when type == DataType.Int16:
                    bytes = BitConverter.GetBytes((Int16)value);
                    break;
                case DataType type when type == DataType.Int32:
                    bytes = BitConverter.GetBytes((Int32)value);
                    break;
                case DataType type when type == DataType.Int64:
                    bytes = BitConverter.GetBytes((Int64)value);
                    break;
                case DataType type when type == DataType.UInt16:
                    bytes = BitConverter.GetBytes((UInt16)value);
                    break;
                case DataType type when type == DataType.UInt32:
                    bytes = BitConverter.GetBytes((UInt32)value);
                    break;
                case DataType type when type == DataType.UInt64:
                    bytes = BitConverter.GetBytes((UInt64)value);
                    break;
                case DataType type when type == DataType.Single:
                    bytes = BitConverter.GetBytes((Single)value);
                    break;
                case DataType type when type == DataType.Double:
                    bytes = BitConverter.GetBytes((Double)value);
                    break;
                default:
                    throw new ArgumentException("Invalid type provided");
            }

            this.WriteBytes(address, bytes);
        }

        /// <summary>
        /// Writes the values of a specified type in the remote process.
        /// </summary>
        /// <typeparam name="T">The type of the value.</typeparam>
        /// <param name="address">The address where the value is written.</param>
        /// <param name="value">The value to write.</param>
        public void Write<T>(IntPtr address, T value)
        {
            this.Write(typeof(T), address, (Object)value);
        }

        /// <summary>
        /// Write an array of bytes in the remote process.
        /// </summary>
        /// <param name="address">The address where the array is written.</param>
        /// <param name="byteArray">The array of bytes to write.</param>
        public void WriteBytes(IntPtr address, Byte[] byteArray)
        {
            // Write the byte array
            Memory.WriteBytes(this.SystemProcess == null ? IntPtr.Zero : this.SystemProcess.Handle, address, byteArray);
        }

        /// <summary>
        /// Writes a string with a specified encoding in the remote process.
        /// </summary>
        /// <param name="address">The address where the string is written.</param>
        /// <param name="text">The text to write.</param>
        /// <param name="encoding">The encoding used.</param>
        public void WriteString(IntPtr address, String text, Encoding encoding)
        {
            // Write the text
            this.WriteBytes(address, encoding.GetBytes(text + '\0'));
        }
    }
    //// End class
}
//// End namespace