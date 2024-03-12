// OPERADORES
int a = 3;
int b = a++; // ++ é um acumulador
// neste caso ++ vai somar a + 1
// entretanto o acumulo vai ocorrer depois da atribuição
// pois o ++ está do lado direito de a
WriteLine($"a é {a}, b é {b}");
//----------------------------------------------------------------
int c = 3;
int d = ++c;
WriteLine($"c é {c}, d é {d}");
// neste caso ++ está do lado esquerdo de c, 
// portanto o acumulo vai ocorrer antes da atribuição
//----------------------------------------------------------------
//combinando operadores de atribuição
int p = 6;
p += 3; //equivalente a p = p + 3;
p -= 3; //equivalente a p = p - 3;
p *= 3; //equivalente a p = p * 3;
p /= 3; //equivalente a p = p / 3;

//operadores lógicos
bool b_A = true;
bool b_B = false;
WriteLine($"AND  | b_A   | b_B  ") ;
WriteLine($"b_A  | {b_A & b_A, -5} | {b_A & b_B, -5}");
WriteLine($"b_B  | {b_B & b_A, -5} | {b_B & b_B, -5}");
WriteLine();
WriteLine($"OR   | b_A   | b_B  ") ;
WriteLine($"b_A  | {b_A | b_A, -5} | {b_A | b_B, -5}");
WriteLine($"b_B  | {b_B | b_A, -5} | {b_B | b_B, -5}");
WriteLine();
WriteLine($"XOR  | b_A   | b_B  ") ;
WriteLine($"b_A  | {b_A ^ b_A, -5} | {b_A ^ b_B, -5}");
WriteLine($"b_B  | {b_B ^ b_A, -5} | {b_B ^ b_B, -5}");
