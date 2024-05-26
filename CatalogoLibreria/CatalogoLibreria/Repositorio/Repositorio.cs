using CatalogoLibreria.Modelos;
using Microsoft.EntityFrameworkCore;

namespace CatalogoLibreria.Repositorio
{
    public class RepositorioClientes : IRepositorioClientes
    {
        private readonly LibreriaDBContext _context;

        public RepositorioClientes(LibreriaDBContext context)
        {
            _context = context;
        }

        public async Task<Cliente> Add(Cliente cliente)
        {
            await _context.Clientes.AddAsync(cliente);
            await _context.SaveChangesAsync();
            return cliente;
        }
        public async Task Delete(int id)
        {
            var cliente = await _context.Clientes.FindAsync(id);
            if (cliente != null)
            {
                _context.Clientes.Remove(cliente);
                await _context.SaveChangesAsync();
            }
            }

        public async Task<List<Cliente>> GetAll()
        {
            return await _context.Clientes.ToListAsync();
        }

        public async Task<Cliente> Get(int id)
        {
            return await _context.Clientes.FindAsync(id);
        }
        public async Task Update(int id, Cliente cliente)
        {
            var clienteactual = await _context.Clientes.FindAsync(id);
            if (clienteactual != null)
            {
                clienteactual.Nombre = cliente.Nombre;
                clienteactual.Correo = cliente.Correo;
                clienteactual.Telefono = cliente.Telefono;
                await _context.SaveChangesAsync();
            }
        }

    }
}
