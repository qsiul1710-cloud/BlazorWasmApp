# Guía Paso a Paso: Commit y Push en Visual Studio 2026

## Método 1: Desde el Menú Git (Recomendado)

### Paso 1: Abre el Menú Git
1. **En la barra superior**, haz click en **Git**
2. Deberías ver un menú desplegable con opciones como:
   - Changes
   - Branches
   - Fetch
   - Pull
   - Push
   - etc.

### Paso 2: Haz Click en "Changes"
- Esto abrirá la ventana/pestaña "Git Changes"
- Verás una lista de archivos modificados

### Paso 3: Ver los Cambios
La ventana mostrará:
- **Archivos sin preparar (Unstaged)**:
  - `.github/workflows/deploy.yml` (modificado)
  - `wwwroot/.nojekyll` (nuevo)
  - `wwwroot/404.html` (nuevo)
  - `wwwroot/index.html` (modificado)
  - `.gitignore` (nuevo)
  - y otros...

### Paso 4: Preparar Cambios para Commit
**Opción A: Preparar todo**
- En la ventana Git Changes, haz click en el botón **"+"** (o Stage All)
- Todos los archivos se moverán a "Staged Changes"

**Opción B: Preparar archivos individuales**
- Haz click derecho en cada archivo > **Stage**

### Paso 5: Escribir Mensaje de Commit
1. En la ventana Git Changes, verás un campo de texto que dice:
   ```
   Commit Message (Ctrl+Enter to commit)
   ```
2. Haz click y escribe:
   ```
   fix: Enable GitHub Pages deployment

   - Fixed workflow to listen on master branch
   - Added .nojekyll for GitHub Pages
   - Updated base href for correct routing
   ```

### Paso 6: Hacer Commit
1. Presiona **Ctrl+Enter** O
2. Haz click en el botón **"Commit All"** (o similar)

### Paso 7: Push a GitHub
Después de commitear:
1. Vuelve a **Git > Push** en el menú
   O haz click en el botón **"Push"** en la ventana de cambios
2. Visual Studio subirá los cambios a GitHub
3. Verás un mensaje de confirmación

---

## Método 2: Desde el Menú Contextual

1. **En Solution Explorer**, haz click derecho en la solución/proyecto
2. Haz click en **"Commit..."** o **"Push..."**
3. Sigue los pasos anteriores

---

## Método 3: Desde Git > Commit to Branch

1. **Menú superior**: Git > Commit to Branch
2. Se abrirá la ventana de commit
3. Escribe el mensaje y haz commit
4. Luego: Git > Push

---

## Método 4: Desde Git > Push (Si ya están preparados)

1. **Menú superior**: Git > Push
2. Visual Studio commitará y pusheará automáticamente

---

## Si Aún No Ves Git Changes

**Alternativa**: Ir a **View > Git Changes** en el menú superior:
1. View > Git Changes
2. Se abrirá la ventana en el panel inferior o lateral

---

## Verificación: Después de Push

1. Ve a: https://github.com/qsiul1710-cloud/BlazorWasmApp
2. Actualiza la página (F5)
3. Verás los cambios en los archivos
4. Ve a la pestaña **"Actions"**
5. Deberías ver el workflow "Deploy to GitHub Pages" ejecutándose

---

## Si Hay Errores

**En Visual Studio**:
- Si ves un error de autenticación, Visual Studio te pedirá que inicies sesión en GitHub
- Sigue los pasos de autenticación

**En GitHub**:
- Ve a Actions tab
- Haz click en el workflow "Deploy to GitHub Pages"
- Revisa el log del error

---

## Resumen Rápido

```
1. Git > Changes
2. Stage All (botón +)
3. Escribe mensaje: "fix: Enable GitHub Pages deployment"
4. Ctrl+Enter (o click Commit All)
5. Git > Push
6. ¡Listo!
```

La app estará online en 2-3 minutos en:
**https://qsiul1710-cloud.github.io/BlazorWasmApp/**
