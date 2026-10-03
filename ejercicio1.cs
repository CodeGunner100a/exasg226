
   //ejercicio 1 -----------------------------------------------

        public void ejercicio1(int m)
        {
            for (int i = m; i <= n; i = i + m)
            {
                for (int j = i + m; j <= n; j = j + m)
                {
                    if (v[j] < v[i])
                    {
                        intercambiar(i, j);
                    }
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
            //llamada  ejercicio1
            v1.ejercicio1(int.Parse(textBox2.Text));
