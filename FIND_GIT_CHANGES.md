# 🔍 CÓMO ENCONTRAR GIT CHANGES EN VISUAL STUDIO 2026

Si no encuentras la pestaña de Git Changes, sigue estos pasos exactos:

## OPCIÓN 1: Menú Git (Lo más simple)

```
Visual Studio (barra superior)
  ↓
Git (click aquí)
  ↓
Verás un menú con:
  - Changes
  - Branches
  - Fetch
  - Pull
  - Push
  - Commit to Branch
  - etc.
  ↓
Click en "Changes"
```

**Resultado:** Se abre una ventana con los cambios pendientes

---

## OPCIÓN 2: View Menu (Si el menú Git no funciona)

```
Visual Studio (barra superior)
  ↓
View (click)
  ↓
Busca "Git" en la lista
  ↓
Click en "Git Changes"
```

**Resultado:** Se abre la ventana Git Changes

---

## OPCIÓN 3: Atajo de Teclado

```
Presiona: Ctrl + 0, Ctrl + G
(Ctrl + 0, LUEGO Ctrl + G)
```

**Resultado:** Abre Git Changes directamente

---

## OPCIÓN 4: Desde Solution Explorer

```
1. En la derecha está "Solution Explorer"
2. Click derecho en "BlazorWasmApp" (la solución)
   ↓
   Verás un menú contextual con:
   - Git Changes
   - Git Commit
   - Git Fetch
   - Git Pull
   - Git Push
   - Sync (Git)
   ↓
3. Click en "Git Changes"
```

**Resultado:** Abre Git Changes

---

## OPCIÓN 5: Team Explorer (Si tienes activado)

```
1. Si ves una pestaña "Team Explorer" (generalmente abajo a la izquierda)
2. Haz click en ella
3. Debería mostrar opciones de Git
4. Click en "Changes"
```

**Resultado:** Abre Git Changes

---

## UNA VEZ ABIERTA LA VENTANA GIT CHANGES

Verás algo así:

```
┌─────────────────────────────────────────┐
│ Git Changes                             │
├─────────────────────────────────────────┤
│                                         │
│ [+] Branch: master                      │
│                                         │
│ Changes (11 files)                      │
│ ├─ .github/workflows/deploy.yml         │
│ ├─ wwwroot/.nojekyll                   │
│ ├─ wwwroot/404.html                    │
│ ├─ wwwroot/index.html                  │
│ ├─ .gitignore                          │
│ └─ ... más archivos                     │
│                                         │
│ [ +  Stage All ]                        │
│                                         │
│ Commit Message:                         │
│ ┌─────────────────────────────────────┐ │
│ │ (escribe tu mensaje aquí)           │ │
│ └─────────────────────────────────────┘ │
│ [Commit All] [Undo]                     │
│                                         │
│ [↑ Push]  [↓ Pull]  [↻ Fetch]          │
└─────────────────────────────────────────┘
```

---

## PASOS A SEGUIR EN LA VENTANA

### 1️⃣ Stage All (Preparar archivos)
```
Haz click en el botón "+" (o "Stage All")
Todos los archivos se moverán a "Staged Changes"
```

### 2️⃣ Escribe mensaje de commit
```
En el cuadro "Commit Message" escribe:

fix: Enable GitHub Pages deployment

(O cualquier otro mensaje que prefieras)
```

### 3️⃣ Commit
```
Presiona Ctrl+Enter
O haz click en "Commit All"
```

### 4️⃣ Push
```
Haz click en el botón "↑ Push"
O ve a Menú: Git → Push
O presiona: Ctrl+Shift+P
```

**¡LISTO!** Los cambios se suben a GitHub 🚀

---

## VERIFICACIÓN EN GITHUB

Después de push:

1. Ve a: https://github.com/qsiul1710-cloud/BlazorWasmApp
2. Debería mostrar: "Latest commit ... hace unos segundos"
3. Pestaña **Code**: Verás los archivos nuevos
4. Pestaña **Actions**: Workflow ejecutándose
5. Espera 2-3 minutos a que termine

---

## 🎬 VIDEO MENTAL

```
Abres VS 2026
  ↓
Git → Changes
  ↓
Ves archivos modificados
  ↓
Click en "+" (Stage All)
  ↓
Escribes: "fix: Enable GitHub Pages deployment"
  ↓
Ctrl+Enter (Commit)
  ↓
Git → Push (o Ctrl+Shift+P)
  ↓
¡GitHub recibe todo!
  ↓
Workflow empieza automáticamente
  ↓
En 2-3 minutos: ¡App online!
```

---

## ⚠️ PROBLEMAS COMUNES

### "No veo ningún menú Git"
- Verifica: ¿Abriste la carpeta del repositorio en Visual Studio?
- O intenta: Git > Clone Repository > Paste URL

### "Git Changes abre pero no ves cambios"
- Solution Explorer > Click derecho solución > Git > Refresh
- O: Git > Fetch > Git > Pull

### "El botón de commit está deshabilitado"
- Primero haz click en "+" para preparar los archivos
- Luego escribe el mensaje
- Luego intenta commit

---

**¡Si aún tienes problemas, avísame exactamente qué ves en pantalla!** 📸
