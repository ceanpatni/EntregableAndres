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
    public class OrderItemController : Controller
    {

        private readonly IOrderItemRepository _orderItemRepository;

         private readonly IProductRepository _productRepository;

        private readonly ILogger<OrderItemController> _logger;

        public OrderItemController(IOrderItemRepository orderItemRepository, ILogger<OrderItemController> logger, IProductRepository productRepository)
        {
            _orderItemRepository = orderItemRepository;
            _logger = logger;
            _productRepository = productRepository;

        }

        public async Task<IActionResult> Index()
        {
            var ordersitems = await _orderItemRepository.GetAllAsync();
            _logger.LogInformation("Listado de ordenes:");


            return View(ordersitems);
        }

        // GET: api/OrderItem
        [HttpGet]
        public async Task<ActionResult<IEnumerable<OrderItem>>> GetAll()
        {
            var orderItems = await _orderItemRepository.GetAllAsync();
            return Ok(orderItems);
        }

        // GET: api/OrderItem/5
        [HttpGet("{id}")]
        public async Task<ActionResult<OrderItem>> GetById(int id)
        {
            var orderItem = await _orderItemRepository.GetByIdAsync(id);

            if (orderItem == null)
            {
                return NotFound();
            }

            return Ok(orderItem);
        }

        // GET: api/OrderItem/byOrder/5
        [HttpGet("byOrder/{orderId}")]
        public async Task<ActionResult<IEnumerable<OrderItem>>> GetByOrderId(int orderId)
        {
            var orderItems = await _orderItemRepository.GetByOrderIdAsync(orderId);
            return Ok(orderItems);
        }


        /// <summary>
        /// Muestra el formulario para crear un nuevo OrderItem (ítem de pedido).
        /// </summary>
        /// <remarks>
        /// Este método se encarga de preparar la vista para la creación de un nuevo OrderItem. 
        /// Recupera todos los productos disponibles desde el repositorio y los pasa a la vista 
        /// para que el usuario pueda seleccionar uno al momento de crear un ítem de pedido.
        /// </remarks>
        /// <returns>La vista `Create` que muestra un formulario con los productos disponibles.</returns>
        /// <response code="200">La vista fue renderizada correctamente, con la lista de productos disponibles.</response>

        public async Task<IActionResult> Create()
        {
            ViewData["Products"] = await _productRepository.GetAllAsync();
            return View();
        }

        /// <summary>
        /// Crea un nuevo OrderItem (ítem de pedido).
        /// </summary>
        /// <remarks>
        /// Este método recibe un objeto OrderItem en el cuerpo de la solicitud y lo agrega a la base de datos.
        /// Si el modelo es válido, el ítem de pedido se guarda en el repositorio y el usuario es redirigido a la página de listado (Index).
        /// En caso de que el modelo no sea válido, se retorna la vista para corregir los errores.
        /// </remarks>
        /// <param name="orderItem">El objeto OrderItem que se va a crear.</param>
        /// <returns>Redirige al listado de OrderItems (Index) si el ítem se crea correctamente, o retorna la vista con el modelo si hay errores de validación.</returns>
        /// <response code="200">Ítem de pedido creado exitosamente y redirigido al listado.</response>
        /// <response code="400">El modelo enviado no es válido. Se retorna la vista para corrección.</response>

     
        [HttpPost]
        public async Task<ActionResult<OrderItem>> Create(OrderItem orderItem)
        {

            if (ModelState.IsValid)
            {
                await _orderItemRepository.CreateAsync(orderItem);
                return RedirectToAction(nameof(Index));
            }
            return View(orderItem);
        }


        public async Task<IActionResult> Edit(int id)
        {
            var orderitem = await _orderItemRepository.GetByIdAsync(id);
            ViewData["Products"] = await _productRepository.GetAllAsync();
            _logger.LogInformation("Order encontrado:" + orderitem.Id);
            if (orderitem == null)
            {
                return NotFound();
            }
            return View(orderitem);
        }


        /// <summary>
        /// Actualiza un OrderItem existente.
        /// </summary>
        /// <remarks>
        /// Este método permite modificar un OrderItem en la base de datos. 
        /// El cliente debe enviar un objeto `OrderItem` con los datos modificados, y el servidor intentará actualizar el ítem. 
        /// Si el `OrderItem` con el ID especificado no existe o los datos no son válidos, se devuelve un error.
        /// </remarks>
        /// <param name="id">El ID del OrderItem a actualizar.</param>
        /// <param name="orderItem">El objeto OrderItem con los nuevos datos a actualizar.</param>
        /// <returns>Redirige a la vista de listado (Index) si la actualización es exitosa, o devuelve la vista con el modelo en caso de errores de validación.</returns>
        /// <response code="200">OrderItem actualizado exitosamente y redirigido al listado.</response>
        /// <response code="400">El modelo enviado no es válido. Se retorna la vista para corrección.</response>
        /// <response code="404">El OrderItem con el ID especificado no se encuentra, o hubo un error de concurrencia al actualizar el ítem.</response>

        [HttpPost]
        public async Task<IActionResult> Edit(int id, OrderItem orderItem)
        {
            if (id != orderItem.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _orderItemRepository.UpdateAsync(orderItem);
                    return RedirectToAction(nameof(Index));
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!await OrderItemExists(id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
            }
            return View(orderItem);
        }




        public async Task<IActionResult> Delete(int id)
        {
            var orderItem = await _orderItemRepository.GetByIdAsync(id);
            if (orderItem == null)
            {
                return NotFound();
            }
            return View(orderItem);
        }


        /// <summary>
        /// Elimina un OrderItem confirmado de la base de datos.
        /// </summary>
        /// <remarks>
        /// Este método elimina un `OrderItem` de la base de datos de manera definitiva. Si el ítem está asociado a otros registros, se lanzará una excepción y el ítem no será eliminado.
        /// Si ocurre un error durante el proceso de eliminación, se redirige al índice con un mensaje de error.
        /// </remarks>
        /// <param name="id">El ID del OrderItem que se va a eliminar.</param>
        /// <returns>Redirige a la vista de listado (Index) tras la eliminación exitosa, o a la vista con un mensaje de error en caso de problemas.</returns>
        /// <response code="200">OrderItem eliminado exitosamente y redirigido al listado.</response>
        /// <response code="400">No se puede eliminar el OrderItem debido a problemas de asociación con otros registros.</response>
        /// <response code="500">Hubo un error inesperado durante el proceso de eliminación.</response>

        [HttpPost, ActionName("Delete")]
   
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            try
            {
                await _orderItemRepository.DeleteAsync(id);
                return RedirectToAction(nameof(Index));
            }
            catch (DbUpdateException ex)
            {
                // Captura la excepción si hay problemas al eliminar el producto
                _logger.LogError("Error al eliminar el producto: " + ex.Message);

                // Puedes agregar un mensaje de error que se pasará a la vista
                TempData["ErrorMessage"] = "No se puede eliminar el producto porque está asociado a otros registros.";

                // Redirige de vuelta al índice (o donde prefieras)
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                // Si ocurre cualquier otro error, lo registramos y mostramos un mensaje genérico
                _logger.LogError("Error al eliminar el producto: " + ex.Message);

                TempData["ErrorMessage"] = "Hubo un problema al eliminar el producto.";

                return RedirectToAction(nameof(Index));
            }
        }


        private async Task<bool> OrderItemExists(int id)
        {
            var orderItem = await _orderItemRepository.GetByIdAsync(id);
            return orderItem != null;
        }
    }
}
