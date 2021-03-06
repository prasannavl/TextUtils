﻿// Author: Prasanna V. Loganathar
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
// Created: 1:54 AM 18-04-2014

namespace TextUtils
{
    using System.Text;

    using TextUtils.Extensions;

    public static class StringHelpers
    {
        public static string[] RepeatAsArray(string text, int count)
        {
            return text.RepeatAsArray(count);
        }

        public static string Repeat(string text, int count)
        {
            return text.Repeat(count);
        }

        public static string RepeatLine(string text, int count)
        {
            return text.RepeatLine(count);
        }

        public static byte[] ToByteArray(string text, Encoding encoding = null)
        {
            return text.ToByteArray(encoding);
        }
    }
}