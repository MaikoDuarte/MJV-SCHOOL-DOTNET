[HttpPost]
public IActionResult Index([Bind("Nome, Sobrenome")] Usuario usuario)
{
  ViewBag.Autenticado = true;
  ViewData["NomeCompleto"] = "Maiko";
  TempData["Mensagem"] = "Mensagem";

  var u = new Usuario()
  {
    nome = usuario.Nome, Sobrenome = usuario.Sobrenome
  };
  return View(u);
}