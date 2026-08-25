using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp.Pages;

/// <summary>
/// Index page model for demonstrating user-based restrictions 
/// on annotations and form fields in PDF Viewer.
/// 
/// Features:
/// - User dropdown selection (John, Alice)
/// - Annotations are locked/unlocked based on author name
/// - Form fields can be restricted to specific users
/// - Uses isLock property to prevent editing of annotations by unauthorized users
/// </summary>
public class IndexModel : PageModel
{
    /// <summary>
    /// Gets sample users for the dropdown.
    /// </summary>
    public List<UserInfo> Users { get; set; } = new()
    {
        new UserInfo { Name = "John", UserId = "john_id", Description = "Can edit annotations created by John" },
        new UserInfo { Name = "Alice", UserId = "alice_id", Description = "Can edit annotations created by Alice" }
    };

    public void OnGet()
    {
        // Initialize the page
    }
}

/// <summary>
/// Represents a user in the system for annotation permission management.
/// </summary>
public class UserInfo
{
    public string Name { get; set; }
    public string UserId { get; set; }
    public string Description { get; set; }
}
