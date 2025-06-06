(**
---
title: Literate Script
category: Examples
categoryindex: 2
index: 1
---
# Example: Using Literate Script Content

This file demonstrates how to write literate F# script
files (`*.fsx`) that can be transformed into nice HTML
using the `literate.fsx` script from the [F# Formatting
package](http://fsprojects.github.io/FSharp.Formatting).

As you can see, a comment starting with a double asterisk
is treated as part of the document and is transformed
using Markdown, which means that you can use:

 - Unordered or ordered lists
 - Text formatting including **bold** and _emphasis_

And numerous other [Markdown][md] features.

 [md]: http://daringfireball.net/projects/markdown

## Writing F# code

Code that is not inside the comment will be formatted as
a sample snippet.
*)

/// The Hello World of functional languages!
let rec factorial x =
    if x = 0 then 1 else x * (factorial (x - 1))

let f10 = factorial 10

(**
Hiding code
-----------

If you want to include some code in the source code,
but omit it from the output, you can use the `hide`
command.
*)

(*** hide ***)
/// This is a hidden answer
let hidden = 42

(**
The value will be defined in the F# code and so you
can use it from other (visible) code and get the correct
tooltips:
*)

let answer = hidden

(**
## Moving code around

Sometimes, it is useful to first explain some code that
has to be located at the end of the snippet (perhaps
because it uses some definitions discussed in the middle).
This can be done using `include` and `define` commands.

The following snippet gets the correct tooltips, even though
it uses `laterFunction`:
*)

(*** include:later-bit ***)

(**
Then, we can explain how `laterFunction` is defined:
*)

let laterFunction () = "Not very difficult, is it?"

(**
This example covers pretty much all features that are
currently implemented in `literate.fsx`, but feel free
to [fork the project on GitHub][fs] and add more
features or report bugs!

  [fs]: https://github.com/fsprojects/FSharp.Formatting

*)

(*** define:later-bit ***)
let sample = laterFunction () |> printfn "Got: %s"
