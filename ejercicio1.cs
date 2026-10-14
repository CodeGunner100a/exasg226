        //ejercicio 1 ----------------------------------------------- aaa
       


  public void ejercicio1(int a, int b)
        {
            int k = a;

            for (int i = a; i <= b; i++)
            {
                if (Buscar_ele_Rango(v[i], a, k - 1) == false)
                {
                    v[k] = v[i];
                    k++;
                }
            }

            int elim = b - k + 1;

            for (int i = b + 1; i <= n; i++)
            {
                v[i - elim] = v[i];
            }

            n = n - elim;
        }

        public bool Buscar_ele_Rango(int ele, int a, int b)
        {
            int i = a;
            bool ban = false;

            while ((i <= b) && (ban == false))
            {
                if (v[i] == ele)
                    ban = true;
                else
                    i++;
            }

            return ban;
        }

 //llamada  ejercicio1
            v1.ejercicio1(int.Parse(textBox2.Text), int.Parse(textBox3.Text));

            //textBox5.Text = v1.Descargar();


