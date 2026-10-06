  //ejercicio 2 -----------------------------------------------
          public void ejercicio2(int a, int b, ref Vector ve, ref Vector vf)
        {
            ve.n = 0;
            vf.n = 0;

            Ordenar_Asc_Rango(a, b);

            for (int i = a; i <= b; i++)
            {
                NEnt num = new NEnt();
                num.Cargar(v[i]);

                if (num.VerifPrimo())
                {
                    if (ve.Buscar_ele(v[i]) == false)
                    {
                        int c = 0;

                        for (int j = a; j <= b; j++)
                        {
                            if (v[j] == v[i])
                                c++;
                        }

                        ve.insertar(v[i]);
                        vf.insertar(c);
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
 //llamada  ejercicio2




            v1.ejercicio2(int.Parse(textBox2.Text),int.Parse(textBox3.Text), ref v2,ref v3);

            //textBox7.Text = v2.Descargar();
            //textBox8.Text = v3.Descargar();
