
        //ejercicio 2 -----------------------------------------------

       public void ejercicio2(int m, ref Vector ve, ref Vector vf)
        {
            ve.n = 0;
            vf.n = 0;

            for (int i = m; i <= n; i = i + m)
            {
                if (ve.Buscar_ele(v[i]) == false)
                    ve.insertar(v[i]);
            }

            ve.Ordenar_Asc_Rango(1, ve.n);

            for (int i = 1; i <= ve.n; i++)
            {
                int c = 0;

                for (int j = m; j <= n; j = j + m)
                {
                    if (v[j] == ve.v[i])
                        c++;
                }

                vf.insertar(c);
            }
        }

        public void Ordenar_Asc_Rango(int a, int b)
        {
            for (int i = a; i <= b - 1; i++)
            {
                for (int j = i + 1; j <= b; j++)
                {
                    if (v[j] < v[i])
                        intercambiar(i, j);
                }
            }
        }

        public bool Buscar_ele(int ele)
        {
            int i = 1;
            bool ban = false;

            while ((i <= n) && (ban == false))
            {
                if (v[i] == ele)
                    ban = true;
                else
                    i++;
            }

            return ban;
        }

        public void insertar(int ele)
        {
            n = n + 1;
            v[n] = ele;
        }

        public void intercambiar(int pos1, int pos2)
        {
            int aux;
            aux = v[pos1];
            v[pos1] = v[pos2];
            v[pos2] = aux;
        }

 //llamada  ejercicio2

            v1.ejercicio2(int.Parse(textBox2.Text), ref v2, ref v3);
            //textBox5.Text = v1.Descargar();









