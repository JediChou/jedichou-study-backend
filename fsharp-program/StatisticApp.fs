// Program StatisticApp.fs
let s1 = [|9.6; 7.5; 10.2; 11.8; 7.8; 6.4; 12.8; 10.7|];
let s2 = [|12.5; 9.0; 7.2; 13.0; 5.5; 7.0; 6.5; 11.3|];
let avg1 = Array.average(s1);
let avg2 = Array.average(s2);
let var1 = sqrt(Array.sumBy (fun x ->  (x-avg1)*(x-avg1)) s1) / float(Array.length s1);
let var2 = sqrt(Array.sumBy (fun x ->  (x-avg2)*(x-avg2)) s2) / float(Array.length s2);
printfn "avg1: %f avg2: %f" avg1 avg2;
printfn "var1: %f var2: %f" var1 var2;