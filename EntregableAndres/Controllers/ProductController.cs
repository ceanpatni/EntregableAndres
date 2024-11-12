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
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;
        private readonly ILogger<ProductController> _logger;

        public ProductController(IProductRepository productRepository, ILogger<ProductController> logger)
        {
            _productRepository = productRepository;
            _logger = logger;
        }


        /// <summary>
        /// Obtiene todos los productos para asignarlos a la vista
        /// </summary>
        /// 
        /// <returns>El productos encontrados.</returns>
        public async Task<IActionResult> Index()
        {
            var products = await _productRepository.GetAllAsync();
            _logger.LogInformation("Listado de productos:");
            foreach (var product in products)
            {
                _logger.LogInformation($"Id: {product.Id}, Name: {product.Name}"); // Ajusta según las propiedades de tu objeto
            }
            
            return View(products);
        }

        public IActionResult Create()
        {
            return View();
        }


        /// <summary>
        ///funcion para crear un producto
        /// </summary>
        /// 
        /// <returns>el producto que fue agregado a la vista si no se agrego si se agrego retorna al index.</returns>
        [HttpPost]
        public async Task<IActionResult> Create(Product product)
        {
            if (ModelState.IsValid)
            {
                await _productRepository.CreateAsync(product);
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }

        /// <summary>
        /// Recupera un producto por su ID y devuelve la vista correspondiente.
        /// </summary>
        /// <remarks>
        /// Este endpoint permite obtener los detalles de un producto específico, dado su identificador.
        /// Si no se encuentra el producto, retorna un código de estado 404 (Not Found).
        /// </remarks>
        /// <param name="id">El ID del producto que se desea recuperar.</param>
        /// <returns>La vista con los detalles del producto o un error si no se encuentra.</returns>
        /// <response code="200">Producto encontrado y mostrado en la vista.</response>
        /// <response code="404">El producto con el ID especificado no fue encontrado.</response>

        public async Task<IActionResult> Edit(int id)
        {
            var product = await _productRepository.GetByIdAsync(id);

            _logger.LogInformation("producto encontrado:"+ product.Name);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, Product product)
        {
            if (id != product.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _productRepository.UpdateAsync(product);
                    return RedirectToAction(nameof(Index));
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!await ProductExists(id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
            }
            return View(product);
        }


        /// <summary>
        /// Actualiza un producto existente en el sistema.
        /// </summary>
        /// <remarks>
        /// Este endpoint permite actualizar un producto en el sistema. Se debe enviar el ID del producto en la URL y 
        /// los nuevos datos del producto en el cuerpo de la solicitud. Si el ID no coincide con el producto enviado, 
        /// se retornará un error 404 (Not Found). Si el producto es actualizado correctamente, se redirige a la vista `Index`.
        /// </remarks>
        /// <param name="id">El ID del producto que se desea actualizar.</param>
        /// <param name="product">El objeto del producto con los nuevos datos.</param>
        /// <returns>Redirige a la vista `Index` si la actualización fue exitosa, o devuelve la vista con los datos del producto si ocurre un error.</returns>
        /// <response code="200">Producto actualizado exitosamente y redirigido a `Index`.</response>
        /// <response code="400">La solicitud no es válida o el modelo está incorrecto.</response>
        /// <response code="404">El producto con el ID especificado no fue encontrado.</response>
        public async Task<IActionResult> Details(int id)
        {
            var product = await _productRepository.GetByIdAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        public async Task<IActionResult> Delete(int id)
        {
            _logger.LogInformation("ingresamos aqui producto encontrado:" + id);
            var product = await _productRepository.GetByIdAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        /// <summary>
        /// Elimina un producto confirmado del sistema.
        /// </summary>
        /// <remarks>
        /// Este endpoint maneja la eliminación de un producto. Si el producto está asociado a otros registros en la base de datos, 
        /// puede generar una excepción de tipo DbUpdateException. En este caso, se muestra un mensaje de error y no se elimina el producto.
        /// Si ocurre cualquier otro error durante el proceso de eliminación, se captura y muestra un mensaje genérico.
        /// Si la eliminación es exitosa, se redirige al índice de productos.
        /// </remarks>
        /// <param name="id">El ID del producto a eliminar.</param>
        /// <returns>Redirige a la vista `Index` si la eliminación es exitosa, o muestra un mensaje de error si ocurre un problema.</returns>
        /// <response code="200">El producto fue eliminado exitosamente.</response>
        /// <response code="400">Hubo un error al intentar eliminar el producto debido a asociaciones en la base de datos.</response>
        /// <response code="500">Ocurrió un error inesperado al intentar eliminar el producto.</response>

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            try
            {
                _logger.LogInformation("eliminamos producto encontrado:" + id);
                await _productRepository.DeleteAsync(id);
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

        private async Task<bool> ProductExists(int id)
        {
            var product = await _productRepository.GetByIdAsync(id);
            return product != null;
        }
    }
}
