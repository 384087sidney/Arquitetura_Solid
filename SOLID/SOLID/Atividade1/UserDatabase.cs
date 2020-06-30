using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.Atividade1
{
    // Classe responsável por retornar a lista de usuários
    public class UserDatabase
    {

        private static List<Usuario> usuarios;

        public UserDatabase()
        {
            usuarios = new List<Usuario>();
            usuarios.Add(new Usuario("Cleber", "cleber@gmail.com", "12345"));
            usuarios.Add(new Usuario("Joana", "joana@yahoo.com", "54325"));
            usuarios.Add(new Usuario("Wilson Oliveira", "w.oliveira@gmail.com", "85094"));
            usuarios.Add(new Usuario("Tales Franco", "tales.franco@gmail.com", "12847"));
        }

        public static List<Usuario> obterTodosUsuarios()
        {
            return usuarios;
        }

    }

}
