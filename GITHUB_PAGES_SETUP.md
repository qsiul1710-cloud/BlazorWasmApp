# Instrucciones para Desplegar a GitHub Pages

## Paso 1: Crear Repositorio en GitHub Pages desde Visual Studio

1. **Abre Visual Studio** y carga tu solución `BlazorWasmApp.slnx`

2. **Ve a Git > Create Git Repository** (o Git > Publish to GitHub)
   - Versión simplificada: Menú superior > Git > Create Git Repository

3. **Completa los datos:**
   - Repository name: `BlazorWasmApp` (o el nombre que prefieras)
   - Select a local path: `C:\Users\User\source\repos\BlazorWasmApp`
   - Description (opcional): "Aplicación de Gestión de Lotes y Análisis"
   - Public: ✅ (para que GitHub Pages funcione)
   - Add .gitignore: ✅ (ya lo tenemos)
   - License: Selecciona MIT u otro
   - Click "Create and Push"

4. **Espera a que se complete la subida**

## Paso 2: Configurar GitHub Pages

1. **Ve a tu repositorio en GitHub** (https://github.com/tuusuario/BlazorWasmApp)

2. **Settings > Pages**
   - Source: Deploy from a branch
   - Branch: `main` (o `master`)
   - Folder: `/ (root)` 
   - Click "Save"

3. **Build & Deploy > Actions**
   - Verifica que el workflow se ejecute exitosamente
   - Espera a que termine (aprox 1-2 minutos)

## Paso 3: Compilar para Producción

Antes de deploying, compila en modo Release:

```powershell
cd C:\Users\User\source\repos\BlazorWasmApp\
dotnet publish -c Release -o ./publish
```

## Paso 4: Obtener el Link

Después de que GitHub Actions termine:
- Ve a Settings > Pages
- Verás un link como: `https://tuusuario.github.io/BlazorWasmApp/`
- **Este es tu link publico**

## Notas Importantes

⚠️ **GitHub Pages sirve desde el subdirectorio del repo, no desde la raíz**
- Si tu repo es `BlazorWasmApp`, la URL será: `https://tuusuario.github.io/BlazorWasmApp/`
- Necesitas actualizar `wwwroot/index.html` para reflejar esto

## Actualización de Base URL para GitHub Pages

En `wwwroot/index.html`, asegúrate que:

```html
<base href="/BlazorWasmApp/" />
```

En lugar de:
```html
<base href="/" />
```

O configura dinámicamente en `Program.cs` según el environment.

## Pasos Futuros

Cada vez que hagas cambios:
1. Commit en Visual Studio (Ctrl+0, Ctrl+C)
2. Push a GitHub (Ctrl+0, Ctrl+P)
3. GitHub Actions construye y deploya automáticamente
4. La app se actualiza en la URL dentro de 2 minutos

¡Listo! Tu app estará online y accesible desde cualquier navegador.
