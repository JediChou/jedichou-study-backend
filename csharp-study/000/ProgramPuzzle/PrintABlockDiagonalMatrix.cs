using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cslab.ProgramPuzzle
{
    /// <summary>
    /// Tittle: Print a Block-diagonal Matrix
    /// English Description:
    /// 
    /// Here is a simple, bite-size (byte-sized?) code golf: given a non-empty list of positive
    /// integers less than 10, print a block-diagonal matrix, where the list specifies the size of the
    /// blocks, in order. The blocks must consist of positive integers less than 10. So if you're given
    /// as input
    /// 
    /// [5 1 1 2 3 1]
    /// 
    /// Your output could be, for instance,
    /// 
    /// 1 1 1 1 1 0 0 0 0 0 0 0 0
    /// 1 1 1 1 1 0 0 0 0 0 0 0 0
    /// 1 1 1 1 1 0 0 0 0 0 0 0 0
    /// 1 1 1 1 1 0 0 0 0 0 0 0 0
    /// 1 1 1 1 1 0 0 0 0 0 0 0 0
    /// 0 0 0 0 0 1 0 0 0 0 0 0 0
    /// 0 0 0 0 0 0 1 0 0 0 0 0 0
    /// 0 0 0 0 0 0 0 1 1 0 0 0 0
    /// 0 0 0 0 0 0 0 1 1 0 0 0 0
    /// 0 0 0 0 0 0 0 0 0 1 1 1 0
    /// 0 0 0 0 0 0 0 0 0 1 1 1 0
    /// 0 0 0 0 0 0 0 0 0 1 1 1 0
    /// 0 0 0 0 0 0 0 0 0 0 0 0 1
    ///   
    /// or 
    /// 
    /// 1 2 3 4 5 0 0 0 0 0 0 0 0
    /// 6 7 8 9 1 0 0 0 0 0 0 0 0
    /// 2 3 4 5 6 0 0 0 0 0 0 0 0
    /// 7 8 9 1 2 0 0 0 0 0 0 0 0
    /// 3 4 5 6 7 0 0 0 0 0 0 0 0
    /// 0 0 0 0 0 8 0 0 0 0 0 0 0
    /// 0 0 0 0 0 0 9 0 0 0 0 0 0
    /// 0 0 0 0 0 0 0 1 2 0 0 0 0
    /// 0 0 0 0 0 0 0 3 4 0 0 0 0
    /// 0 0 0 0 0 0 0 0 0 5 6 7 0
    /// 0 0 0 0 0 0 0 0 0 8 9 1 0
    /// 0 0 0 0 0 0 0 0 0 2 3 4 0
    /// 0 0 0 0 0 0 0 0 0 0 0 0 5
    /// 
    /// or something like that. The elements in the matrix must be separated by spaces, and the
    /// rows separated by newlines. There must not be any leading or trailing spaces. You may or
    /// may not print a trailing newline.
    /// 
    /// You may write a function or program, taking input via STDIN (or closest alternative),
    /// command-line argument or function argument, in any convenient string or list format (as
    /// long as it isn't preprocessed). However, the result must be printed to STDOUT (or closet
    /// alternative), as opposed to returned form a function, say.
    /// 
    /// You must not use any built0in functions designed to create block-diagonal matrices.
    /// 
    /// Reference Url:
    ///   http://codegolf.stackexchange.com/questions/45550/print-a-block-diagonal-matrix
    /// </summary>
    class PrintABlockDiagonalMatrix
    {
        public static void Run()
        {
            var m5 = new Matrix(5, 1);
            Console.WriteLine(m5.GetLine(1));
        }

        class Matrix
        {
            private readonly int _row;
            private readonly int _col;
            private readonly int _digit;
            private List<string> _lines;

            public Matrix(int i, int digit)
            {
                _row = i; _col = i;
                if (digit <= 9 && digit >= 0) _digit = digit;
                _lines = new List<string>();
            }

            public string GetLine(int line)
            {
                if (line < 1 || line > _lines.Count) throw new Exception("Line number out of range");
                var temp = _lines.ToArray();
                return temp[line - 1];
            }

            private void AddLine(string content)
            {
                this._lines.Add(content);
            }
        }
    }
}
