using EntregableAndres.Data;
using EntregableAndres.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntregableAndres.Repositories
{
    public class OrderItemRepository :IOrderItemRepository
    {
        private readonly EcommerceDbContext _dbContext;

        public OrderItemRepository(EcommerceDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        // Obtener todos los OrderItems
        public async Task<IEnumerable<OrderItem>> GetAllAsync()
        {
            return await _dbContext.OrderItems
                .Include(oi => oi.Product)
                .Include(oi => oi.Order)
                .ToListAsync();
        }

        // Obtener un OrderItem por Id
        public async Task<OrderItem> GetByIdAsync(int id)
        {
            return await _dbContext.OrderItems
                .Include(oi => oi.Product)
                .Include(oi => oi.Order)
                .FirstOrDefaultAsync(oi => oi.Id == id);
        }

        // Obtener OrderItems por OrderId
        public async Task<IEnumerable<OrderItem>> GetByOrderIdAsync(int orderId)
        {
            return await _dbContext.OrderItems
                .Where(oi => oi.OrderId == orderId)
                .Include(oi => oi.Product)
                .Include(oi => oi.Order)
                .ToListAsync();
        }

        // Crear un nuevo OrderItem
        public async Task CreateAsync(OrderItem orderItem)
        {
            await _dbContext.OrderItems.AddAsync(orderItem);
            await _dbContext.SaveChangesAsync();
        }

        // Actualizar un OrderItem existente
        public async Task UpdateAsync(OrderItem orderItem)
        {
            _dbContext.OrderItems.Update(orderItem);
            await _dbContext.SaveChangesAsync();
        }

        // Eliminar un OrderItem
        public async Task DeleteAsync(int id)
        {
            var orderItem = await _dbContext.OrderItems.FindAsync(id);
            if (orderItem != null)
            {
                _dbContext.OrderItems.Remove(orderItem);
                await _dbContext.SaveChangesAsync();
            }
        }
    }

}
