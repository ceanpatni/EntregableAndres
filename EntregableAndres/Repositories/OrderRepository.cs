using EntregableAndres.Data;
using EntregableAndres.Entity;
using EntregableAndres.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntregableAndres.Repositories
{
}
public class OrderRepository : IOrderRepository
{
    private readonly EcommerceDbContext _dbContext;

    public OrderRepository(EcommerceDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<IEnumerable<Order>> GetAllAsync()
    {
        return await _dbContext.Orders.Include(o => o.OrderItems).ThenInclude(oi => oi.Product).ToListAsync();
    }

    public async Task<Order> GetByIdAsync(int id)
    {
        return await _dbContext.Orders.Include(o => o.OrderItems).ThenInclude(oi => oi.Product).FirstOrDefaultAsync(o => o.Id == id);
    }

    public async Task CreateAsync(Order order)
    {
        await _dbContext.Orders.AddAsync(order);
        await _dbContext.SaveChangesAsync();
    }

    public async Task UpdateAsync(Order order)
    {
        _dbContext.Orders.Update(order);
        await _dbContext.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var order = await _dbContext.Orders.FindAsync(id);
        _dbContext.Orders.Remove(order);
        await _dbContext.SaveChangesAsync();
    }
}


