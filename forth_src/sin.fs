

create sintab
7fff , 8323 , 8647 , 896a ,
8c8b , 8faa , 92c7 , 95e1 ,
98f8 , 9c0a , 9f19 , a223 ,
a527 , a826 , ab1e , ae10 ,
b0fb , b3de , b6b9 , b98c ,
bc55 , bf16 , c1cd , c47a ,
c71c , c9b3 , cc3f , cebf ,
d132 , d39a , d5f4 , d842 ,
da81 , dcb3 , ded6 , e0eb ,
e2f1 , e4e7 , e6ce , e8a5 ,
ea6c , ec23 , edc9 , ef5e ,
f0e1 , f254 , f3b4 , f503 ,
f640 , f76b , f883 , f989 ,
fa7c , fb5c , fc28 , fce2 ,
fd89 , fe1c , fe9c , ff08 ,
ff61 , ffa6 , ffd7 , fff5 ,
ffff , fff5 , ffd7 , ffa6 ,
ff61 , ff08 , fe9c , fe1c ,
fd89 , fce2 , fc28 , fb5c ,
fa7c , f989 , f883 , f76b ,
f640 , f503 , f3b4 , f254 ,
f0e1 , ef5e , edc9 , ec23 ,
ea6c , e8a5 , e6ce , e4e7 ,
e2f1 , e0eb , ded6 , dcb3 ,
da81 , d842 , d5f4 , d39a ,
d132 , cebf , cc3f , c9b3 ,
c71c , c47a , c1cd , bf16 ,
bc55 , b98c , b6b9 , b3de ,
b0fb , ae10 , ab1e , a826 ,
a527 , a223 , 9f19 , 9c0a ,
98f8 , 95e1 , 92c7 , 8faa ,
8c8b , 896a , 8647 , 8323 ,
7fff , 7cdb , 79b7 , 7694 ,
7373 , 7054 , 6d37 , 6a1d ,
6706 , 63f4 , 60e5 , 5ddb ,
5ad7 , 57d8 , 54e0 , 51ee ,
4f03 , 4c20 , 4945 , 4672 ,
43a9 , 40e8 , 3e31 , 3b84 ,
38e2 , 364b , 33bf , 313f ,
2ecc , 2c64 , 2a0a , 27bc ,
257d , 234b , 2128 , 1f13 ,
1d0d , 1b17 , 1930 , 1759 ,
1592 , 13db , 1235 , 10a0 ,
f1d , daa , c4a , afb ,
9be , 893 , 77b , 675 ,
582 , 4a2 , 3d6 , 31c ,
275 , 1e2 , 162 , f6 ,
9d , 58 , 27 , 9 ,
0 , 9 , 27 , 58 ,
9d , f6 , 162 , 1e2 ,
275 , 31c , 3d6 , 4a2 ,
582 , 675 , 77b , 893 ,
9be , afb , c4a , daa ,
f1d , 10a0 , 1235 , 13db ,
1592 , 1759 , 1930 , 1b17 ,
1d0d , 1f13 , 2128 , 234b ,
257d , 27bc , 2a0a , 2c64 ,
2ecc , 313f , 33bf , 364b ,
38e2 , 3b84 , 3e31 , 40e8 ,
43a9 , 4672 , 4945 , 4c20 ,
4f03 , 51ee , 54e0 , 57d8 ,
5ad7 , 5ddb , 60e5 , 63f4 ,
6706 , 6a1d , 6d37 , 7054 ,
7373 , 7694 , 79b7 , 7cdb ,

: sin ff and 2* ['] sintab + @ ;
: cos 40 + sin ;

# a = amplitude
# r = degree [0..ff]
# todo: lerp?
: *cos ( a r -- b )
cos over 2* d* drop swap - ;
: *sin ( a r -- b )
sin over 2* d* drop swap - ;

