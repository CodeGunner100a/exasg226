
        //ejercicio 2 -----------------------------------------------

        public void ejercicio2(int a, int b)
        {
            int k = a;

            for (int i = a; i <= b; i++)
            {
                if (frecuenciaRango(v[i], a, b) > 1)
                {
                    intercambiar(i, k);
                    k++;
                }
            }

            Ordenar_Desc_Rango(a, k - 1);
            Ordenar_Desc_Rango(k, b);
        }

        public int frecuenciaRango(int ele, int a, int b)
        {
            int c = 0;

            for (int i = a; i <= b; i++)
            {
                if (v[i] == ele)
                    c++;
            }

            return c;
        }
        public void Ordenar_Desc_Rango(int a, int b)
        {
            for (int i = a; i <= b - 1; i++)
            {
                for (int j = i + 1; j <= b; j++)
                {
                    if (v[j] > v[i])
                        intercambiar(i, j);
                }
            }
        }

        public void intercambiar(int pos1, int pos2)
        {
            int aux;
            aux = v[pos1];
            v[pos1] = v[pos2];
            v[pos2] = aux;
        }


            //llamada  ejercicio2

            v1.ejercicio2(
        int.Parse(textBox2.Text),
        int.Parse(textBox3.Text));












