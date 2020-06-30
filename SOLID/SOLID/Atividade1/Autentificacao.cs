using System;
using System.Collections.Generic;
using System.Linq;

namespace SOLID.Atividade1
{
    public class AutentificacaoUsuario
    { 
        public static bool autenticarUsuario(Usuario usuario)
        {
            if (usuarioExistente(usuario))
            {
                List<Usuario> usuarios = UserDatabase.obterTodosUsuarios();
                bool usuarioAutenticado = usuarios.Where(user => user.getEmail().Equals(usuario.getEmail()) &&
                                user.getSenha().Equals(usuario.getSenha())).FirstOrDefault() != null; 

                if (usuarioAutenticado)
                {
                    Console.WriteLine("Usuário autenticado com sucesso!");
                }
                else
                {
                    Console.WriteLine("e-mail ou senha incorretos!");
                }

                return usuarioAutenticado;
            }
            else
            {
                Console.WriteLine("Usuário não cadastrado!");
                return false;
            }

        }

        private static bool usuarioExistente(Usuario usuario)
        {
            List<Usuario> usuarios = UserDatabase.obterTodosUsuarios();
            bool usuarioExistente = usuarios.Where(user => user.getEmail().Equals(usuario.getEmail()))
                .FirstOrDefault() != null;
            return usuarioExistente;
        }

    }
}