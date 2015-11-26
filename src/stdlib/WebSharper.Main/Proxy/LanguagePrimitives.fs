// $begin{copyright}
//
// This file is part of WebSharper
//
// Copyright (c) 2008-2015 IntelliFactory
//
// Licensed under the Apache License, Version 2.0 (the "License"); you
// may not use this file except in compliance with the License.  You may
// obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or
// implied.  See the License for the specific language governing
// permissions and limitations under the License.
//
// $end{copyright}

[<WebSharper.Core.Attributes.Proxy
    "Microsoft.FSharp.Core.LanguagePrimitives, \
     FSharp.Core, Culture=neutral, \
     PublicKeyToken=b03f5f7f11d50a3a">]
module private WebSharper.LanguagePrimitivesProxy

[<Inline>]
[<JavaScript>]
let GenericEquality<'T> (a: 'T) (b: 'T) = Unchecked.equals a b

[<Inline>]
[<JavaScript>]
let GenericEqualityER<'T> (a: 'T) (b: 'T) = Unchecked.equals a b

[<Inline>]
[<JavaScript>]
let GenericComparison<'T> (a: 'T) (b: 'T) = Unchecked.compare a b

[<Inline>]
[<JavaScript>]
let GenericHash<'T> (x: 'T) = Unchecked.hash x

[<Inline>]
[<JavaScript>]
let GenericComparisonWithComparer<'T> (c: System.Collections.IComparer) (a: 'T) (b: 'T) = c.Compare(a, b)

[<Inline>]
[<JavaScript>]
let GenericEqualityWithComparer<'T> (c: System.Collections.IEqualityComparer) (a: 'T) (b: 'T) = c.Equals(a, b)

