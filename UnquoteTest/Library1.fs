module M

module N =
    [<AutoOpen>]
    module NA = 
        let (++) x y = x + y

open N
open Swensen.Unquote

let _ = 1 =? 1 
let _ = 1 ++ 2
