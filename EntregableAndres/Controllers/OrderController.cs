using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EntregableAndres.Entity;
using EntregableAndres.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace EntregableAndres.Controllers
{

    public class OrderController : Controller
    {
        private readonly IOrderRepository _orderRepository;
        private readonly ILogger<OrderController> _logger;

        public OrderController(IOrderRepository orderRepository,ILogger<OrderController> logger)
        {
            _orderRepository = orderRepository;
            _logger = logger;

        }

        public async Task<IActionResult> Index()
        {
            var orders = await _orderRepository.GetAllAsync();
            _logger.LogInformation("Listado de ordenes:"+orders);
           

            return View(orders);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Order>>> GetAll()
        {
            var orders = await _orderRepository.GetAllAsync();
            return Ok(orders);
        }


        /// <summary>
        /// funcion para crear una orden
        /// </summary>
        /// 
        /// <returns>el producto que fue agregado a la vista si no se agrego si se agrego retorna al index.</returns>

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Order order)
        {
            if (ModelState.IsValid)
            {
                await _orderRepository.CreateAsync(order);
                return RedirectToAction(nameof(Index));
            }
            return View(order);
        }


        /// <summary>
        /// Actualiza una orden existente.
        /// </summary>
        /// <remarks>
        /// Este endpoint permite actualizar los detalles de una orden ya existente, incluyendo los productos y las cantidades.
        /// Si la orden no existe, se retorna un código de estado 404 (Not Found).
        /// </remarks>
        /// <param name="id">El ID de la orden que se desea actualizar.</param>
        /// <param name="order">El objeto de la orden con los nuevos detalles que se actualizarán.</param>
        /// <returns>Un resultado de acción que indica si la operación fue exitosa o no.</returns>
        /// <response code="204">Orden actualizada correctamente.</response>
        /// <response code="400">La solicitud es inválida (por ejemplo, si el ID de la orden no coincide con el del objeto).</response>
        /// <response code="404">La orden con el ID especificado no fue encontrada.</response>

        [HttpPost]
        public async Task<IActionResult> Edit(int id, Order order)
        {
            _logger.LogError("vamos a lograrlo ");
            if (id != order.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _orderRepository.UpdateAsync(order);
                    return RedirectToAction(nameof(Index));
                }
                catch (DbUpdateConcurrencyException ex)
                {
                    _logger.LogError("Error al eliminar el producto: " + ex.Message);

                    // Puedes agregar un mensaje de error que se pasará a la vista
                    TempData["ErrorMessage"] = "No se puede eliminar la orden porque está asociado a otros registros. "+ex.Message;

                    if (!await OrderExists(id))
                    {
                        return RedirectToAction(nameof(Index));
                    }
                    else
                    {

                        return RedirectToAction(nameof(Index));
                    }
                }
                catch (Exception ex)
                {
                    // Si ocurre cualquier otro error, lo registramos y mostramos un mensaje genérico
                    _logger.LogError("Error al eliminar el producto: " + ex.Message);

                    TempData["ErrorMessage"] = "Hubo un problema al eliminar el producto.";

                    return RedirectToAction(nameof(Index));
                }
            }
            return View(order);
        }

        
        public async Task<IActionResult> Delete(int id)
        {
            _logger.LogInformation("ingresamos aqui order encontrado:" + id);
            var order = await _orderRepository.GetByIdAsync(id);
            if (order == null)
            {
                return NotFound();
            }
            return View(order);
        }


        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            try
            {
                _logger.LogInformation("eliminamos order encontrado:" + id);
                await _orderRepository.DeleteAsync(id);
                return RedirectToAction(nameof(Index));
            }
            catch (DbUpdateException ex)
            {
                // Captura la excepción si hay problemas al eliminar el producto
                _logger.LogError("Error al eliminar la orden: " + ex.Message);

                // Puedes agregar un mensaje de error que se pasará a la vista
                TempData["ErrorMessage"] = "No se puede eliminar la orden porque está asociado a otros registros.";

                // Redirige de vuelta al índice (o donde prefieras)
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                // Si ocurre cualquier otro error, lo registramos y mostramos un mensaje genérico
                _logger.LogError("Error al eliminar la orden: " + ex.Message);

                TempData["ErrorMessage"] = "Hubo un problema al eliminar la orden.";

                return RedirectToAction(nameof(Index));
            }
        }

        private async Task<bool> OrderExists(int id)
        {
            return await _orderRepository.GetByIdAsync(id) != null;
        }
    }
}
