// Author: Prasanna V. Loganathar
// Project: TextUtils
// 
// Copyright 2014 Launchark. All Rights Reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//  
// Created: 1:49 AM 18-04-2014

namespace TextUtils.Extensions
{
    using System;
    using System.Text;

    public static class StringExtentions
    {
        public static string[] RepeatAsArray(this string source, int count)
        {
            var result = new string[count];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = source;
            }
            return result;
        }

        public static string Repeat(this string source, int count)
        {
            var sb = new StringBuilder(source.Length * count);
            for (int i = 0; i < count; i++)
            {
                sb.Append(source);
            }

            return sb.ToString();
        }

        public static string RepeatLine(this string source, int count)
        {
            var sb = new StringBuilder(source.Length * count);
            for (int i = 0; i < count; i++)
            {
                sb.Append(source + Environment.NewLine);
            }

            return sb.ToString();
        }

        public static byte[] ToByteArray(this string source, Encoding encoding = null)
        {
            if (encoding == null)
            {
                encoding = Encoding.UTF8;
            }
            return encoding.GetBytes(source);
        }
    }
}