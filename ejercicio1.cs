        //ejercicio 1 ----------------------------------------------- aaa
        public void ejercicio1(int m)
        {
            int j = 1;

            for (int i = 1; i <= n; i++)
            {
                if (i % m != 0)
                {
                    v[j] = v[i];
                    j++;
                }
            }

            n = j - 1;
        }

            //llamada  ejercicio1
            v1.ejercicio1(int.Parse(textBox2.Text));
            //textBox5.Text = v1.Descargar();
