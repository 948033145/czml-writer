﻿using System;
using System.IO;
using System.Text;
using JetBrains.Annotations;

namespace GenerateFromSchema
{
    public class CodeWriter : IDisposable
    {
        private const int Indentation = 4;

        private readonly TextWriter m_writer;
        private int m_indent;
        private string m_indentString = "";

        public CodeWriter(TextWriter writer)
        {
            m_writer = writer;
        }

        public CodeWriter(string filename)
            : this(new StreamWriter(filename, false, Encoding.UTF8))
        {
        }

        public void Dispose()
        {
            m_writer.Dispose();
        }

        public void IncreaseIndent()
        {
            ++m_indent;
            m_indentString = new string(' ', m_indent * Indentation);
        }

        public void DecreaseIndent()
        {
            --m_indent;
            m_indentString = new string(' ', m_indent * Indentation);
        }

        public CodeScope OpenScope()
        {
            WriteLine("{");
            IncreaseIndent();

            return new CodeScope(this);
        }

        public void CloseScope()
        {
            DecreaseIndent();
            WriteLine("}");
        }

        public void WriteLine()
        {
            m_writer.WriteLine();
        }

        public void WriteLine(string str)
        {
            m_writer.Write(m_indentString);
            m_writer.WriteLine(str);
        }

        [StringFormatMethod("format")]
        public void WriteLine(string format, params object[] args)
        {
            m_writer.Write(m_indentString);
            m_writer.WriteLine(format, args);
        }

        public sealed class CodeScope : IDisposable
        {
            private readonly CodeWriter m_codeWriter;

            public CodeScope(CodeWriter codeWriter)
            {
                m_codeWriter = codeWriter;
            }

            public void Dispose()
            {
                m_codeWriter.CloseScope();
            }
        }
    }
}