using husshussAPIBack.Data;
using husshussAPIBack.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace husshussAPIBack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly AppDbContext _context;

        public UserController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost("inflencers")]
        public async Task<IActionResult> RegisterInfluencer( Influencer influencer)
        {
            // Vérifier si l'email est présent dans la requête
            if (string.IsNullOrEmpty(influencer.User?.Email))
            {
                return BadRequest(new { message = "Email requis pour associer l'utilisateur." });
            }

            // Récupérer l'utilisateur associé à l'email
            var user = await _context.Users.FirstOrDefaultAsync(u => u.Email == influencer.User.Email);
            if (user == null)
            {
                return NotFound(new { message = "Utilisateur introuvable avec cet email." });
            }

            // Associer l'ID utilisateur à l'influenceur
            influencer.UserID = user.UserID;

            // Ajouter l'influenceur dans la base de données
            _context.Influencers.Add(influencer);
            await _context.SaveChangesAsync();

            return Ok(new { message = "Influenceur enregistré avec succès." });
        }
    

        [HttpPost("register")]
        public async Task<IActionResult> Register(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return Ok(new { message = "Utilisateur enregistré avec succès" });
        }
        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequest loginRequest)
        {
            // Vérifie que le modèle de requête est valide
            if (loginRequest == null || string.IsNullOrEmpty(loginRequest.Email) || string.IsNullOrEmpty(loginRequest.Password))
            {
                return BadRequest(new { message = "Email et mot de passe sont obligatoires" });
            }

            var existingUser = await _context.Users
                .FirstOrDefaultAsync(u => u.Email == loginRequest.Email && u.Password == loginRequest.Password);

            if (existingUser == null)
                return Unauthorized(new { message = "Email ou mot de passe incorrect" });

            return Ok(new { message = "Connexion réussie" });
        }

    }
}
