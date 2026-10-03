  //ejercicio 2 -----------------------------------------------
        public void ejercicio2(int a, int b)
        {
            int p = a;

            for (int i = a; i <= b; i++)
            {
                NEnt num = new NEnt();
                num.Cargar(v[i]);

                if (num.VerifPrimo())
                {
                    intercambiar(i, p);
                    p++;
                }
            }

            Ordenar_Asc_Rango(a, p - 1);
            Ordenar_Asc_Rango(p, b);

            int ip = a;
            int inp = p;

            while ((ip < p) && (inp <= b))
            {
                int aux = v[inp];

                for (int j = inp; j > ip + 1; j--)
                {
                    v[j] = v[j - 1];
                }

                v[ip + 1] = aux;

                ip = ip + 2;
                inp++;
            }
        }

        public void Ordenar_Asc_Rango(int a, int b)
        {
            for (int i = a; i <= b - 1; i++)
            {
                for (int j = i + 1; j <= b; j++)
                {
                    if (v[j] < v[i])
                    {
                        intercambiar(i, j);
                    }
                }
            }
        }


