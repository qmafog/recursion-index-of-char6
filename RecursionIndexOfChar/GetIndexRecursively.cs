using System;

namespace RecursionIndexOfChar
{
    public static class GetIndexRecursively
    {
        public static int GetIndexOfChar(string? str, char value)
        {
            if (str is null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            if (string.IsNullOrEmpty(str))
            {
                return -1;
            }

            if (str[0] == value)
            {
                return 0;
            }

            int indexInSubstring = GetIndexOfChar(str.Substring(1), value);
            if (indexInSubstring != -1)
            {
                return indexInSubstring + 1;
            }

            return -1;
        }

        public static int GetIndexOfChar(string? str, char value, int startIndex, int count)
        {
            if (str is null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            if (string.IsNullOrEmpty(str) || count == 0)
            {
                return -1;
            }

            if (startIndex < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex), "startIndex is less than zero");
            }

            if (startIndex >= str.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex), "startIndex is greater or equals str.Length");
            }

            if (count < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(count), "count is less than zero");
            }

            if (startIndex + count > str.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(count), "startIndex + count > str.Length");
            }

            int indexInSubstring = GetIndexOfChar(str.Substring(startIndex, count), value);
            if (indexInSubstring == -1)
            {
                startIndex = 0;
            }

            return indexInSubstring + startIndex;
        }
    }
}
