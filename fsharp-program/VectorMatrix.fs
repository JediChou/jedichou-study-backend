// Program: VectorMatrix.fs
// Program F#
//   Define a vector v1 and a matrix
//   Need install F# PowerPack package
//   URL: http://fsharppowerpack.codeplex.com/releases

open Microsoft.FSharp.Math

let v1 = vector [1.6; 2.4; 3.2];
let m1 = matrix[
    [1.0; 2.0; 1.5];
    [2.5; 1.0; 0.0];
    [1.0; 0.5; 1.0]
];
let v2 = m1 * v1;
let m2 = Matrix.transpose m1
let m3 = m1 * m2;

printfn "%O" v2
printfn "%O" m3