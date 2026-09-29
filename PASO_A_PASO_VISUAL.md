# 📸 INSTRUCCIONES CON CAPTURAS (Simuladas)

## PASO 1: Abre Visual Studio

```
┌─────────────────────────────────────────────────────┐
│                  Visual Studio 2026                 │
│                                                     │
│ [File] [Edit] [View] [Git] [Project] [Tools]...   │
│                          ↑ Haz clic aquí           │
│                                                     │
│                                                     │
│  BlazorWasmApp.slnx                                 │
│  ├─ BlazorWasmApp.csproj                            │
│  │  ├─ App.razor                                    │
│  │  ├─ Program.cs                                   │
│  │  └─ ...                                          │
│                                                     │
└─────────────────────────────────────────────────────┘
```

---

## PASO 2: Haz Clic en "Git" en el Menú

```
┌─────────────────────────────────────────────────────┐
│ [File] [Edit] [View] [Git] [Project] [Tools]...   │
│                         │                          │
│                         ▼ Se abre un menú          │
│                                                     │
│                   ┌──────────────────────────┐     │
│                   │ Changes            ← AQUÍ│     │
│                   │ Branches                 │     │
│                   │ Fetch                    │     │
│                   │ Pull                     │     │
│                   │ Push                     │     │
│                   │ Commit to Branch         │     │
│                   │ Sync                     │     │
│                   │ ...                      │     │
│                   └──────────────────────────┘     │
│                                                     │
└─────────────────────────────────────────────────────┘
```

---

## PASO 3: Haz Clic en "Changes"

Se abre una ventana como esta:

```
┌──────────────────────────────────────────────────────────┐
│ Git Changes                                   (x)        │
├──────────────────────────────────────────────────────────┤
│                                                          │
│  Branch: master ────────────────────────────────────────  │
│                                                          │
│  ┌─ Changes (Cambios sin preparar)                      │
│  │                                                      │
│  │  .github/workflows/deploy.yml        [modificado]   │
│  │  wwwroot/.nojekyll                   [nuevo]        │
│  │  wwwroot/404.html                    [nuevo]        │
│  │  wwwroot/index.html                  [modificado]   │
│  │  .gitignore                          [nuevo]        │
│  │  GUIA_RAPIDA_GITHUB_PAGES.md        [nuevo]        │
│  │  ... más archivos ...                               │
│  │                                                      │
│  └─────────────────────────────────────────────────────│
│                                                          │
│  [ + Stage All ]   ← Haz clic aquí                      │
│                                                          │
│  Commit Message:                                        │
│  ┌────────────────────────────────────────────────────┐│
│  │ (campo vacío - aquí escribes el mensaje)          ││
│  └────────────────────────────────────────────────────┘│
│                                                          │
│  [Commit All]  [Undo]                                   │
│                                                          │
│  [↑ Push]  [↓ Pull]  [↻ Fetch]                          │
│                                                          │
└──────────────────────────────────────────────────────────┘
```

---

## PASO 4: Haz Clic en "+" (Stage All)

Después de hacer clic, la pantalla se verá así:

```
┌──────────────────────────────────────────────────────────┐
│ Git Changes                                   (x)        │
├──────────────────────────────────────────────────────────┤
│                                                          │
│  Branch: master                                         │
│                                                          │
│  ┌─ Staged Changes (Cambios preparados) ← CAMBIÓ        │
│  │                                                      │
│  │  .github/workflows/deploy.yml                       │
│  │  wwwroot/.nojekyll                                  │
│  │  wwwroot/404.html                                   │
│  │  ... todos tus cambios aquí ...                     │
│  │                                                      │
│  └─────────────────────────────────────────────────────│
│                                                          │
│  Commit Message:                                        │
│  ┌────────────────────────────────────────────────────┐│
│  │ ← Ahora escribe aquí                              ││
│  └────────────────────────────────────────────────────┘│
│                                                          │
│  [Commit All]  [Undo]                                   │
│                                                          │
│  [↑ Push]  [↓ Pull]  [↻ Fetch]                          │
│                                                          │
└──────────────────────────────────────────────────────────┘
```

---

## PASO 5: Escribe el Mensaje de Commit

```
┌──────────────────────────────────────────────────────────┐
│ Git Changes                                              │
├──────────────────────────────────────────────────────────┤
│                                                          │
│  Branch: master                                         │
│                                                          │
│  Staged Changes (11 items)                              │
│  [lista de archivos...]                                 │
│                                                          │
│  Commit Message:                                        │
│  ┌────────────────────────────────────────────────────┐│
│  │fix: Enable GitHub Pages deployment                ││  ← Escribe esto
│  │                                                     ││
│  │(Ctrl+Enter para commitear)                          ││
│  └────────────────────────────────────────────────────┘│
│                                                          │
│  [Commit All]  [Undo]                                   │
│                                                          │
│  [↑ Push]  [↓ Pull]  [↻ Fetch]                          │
│                                                          │
└──────────────────────────────────────────────────────────┘
```

---

## PASO 6: Presiona Ctrl+Enter (o Click "Commit All")

**Opción A: Teclado**
```
Presiona: Ctrl + Enter
(Ctrl y Enter simultáneamente)
```

**Opción B: Ratón**
```
Haz clic en el botón "Commit All"
```

**Resultado:** El mensaje desaparece y se hace el commit

```
┌──────────────────────────────────────────────────────────┐
│ Git Changes                                              │
├──────────────────────────────────────────────────────────┤
│                                                          │
│  Branch: master                                         │
│                                                          │
│  ✅ Commit exitoso hace 5 segundos                      │
│                                                          │
│  Commit Message:                                        │
│  ┌────────────────────────────────────────────────────┐│
│  │ (campo vacío de nuevo)                            ││
│  └────────────────────────────────────────────────────┘│
│                                                          │
│  [Commit All]  [Undo]                                   │
│                                                          │
│  [↑ Push]  [↓ Pull]  [↻ Fetch]                          │
│                                                          │
└──────────────────────────────────────────────────────────┘
```

---

## PASO 7: Haz Push

**Opción A: Atajo de teclado**
```
Presiona: Ctrl + Shift + P
```

**Opción B: Menú**
```
Menú superior: Git → Push
```

**Opción C: Botón**
```
Haz clic en el botón "↑ Push" en la ventana de cambios
```

**Resultado:** Los cambios se suben a GitHub

```
┌──────────────────────────────────────────────────────────┐
│ Git Changes                                              │
├──────────────────────────────────────────────────────────┤
│                                                          │
│  Branch: master                                         │
│                                                          │
│  ✅ Push completado: 11 archivos subidos               │
│     Tu rama está al día con 'origin/master'            │
│                                                          │
│  [Sincronizar cambios...]                               │
│                                                          │
│  [↑ Push]  [↓ Pull]  [↻ Fetch]                          │
│                                                          │
└──────────────────────────────────────────────────────────┘
```

---

## PASO 8: Verifica en GitHub (Espera 1 minuto)

**Ve a:**
```
https://github.com/qsiul1710-cloud/BlazorWasmApp
```

Deberías ver:

```
┌──────────────────────────────────────────────────────────┐
│  <> Code  Issues  Pull requests  Actions  ... Settings  │
│                                                          │
│  qsiul1710-cloud / BlazorWasmApp                         │
│                                                          │
│  ✅ Latest commit: "fix: Enable GitHub Pages deployment"│
│     hace 30 segundos                                    │
│                                                          │
│  📁 .github/                                             │
│  📁 wwwroot/                                             │
│  📄 .gitignore                                           │
│  📄 DEPLOYMENT_COMPLETE.md                              │
│  📄 ... más archivos ...                                │
│                                                          │
└──────────────────────────────────────────────────────────┘
```

---

## PASO 9: Verifica Actions (Pestaña Actions)

```
https://github.com/qsiul1710-cloud/BlazorWasmApp/actions
```

Deberías ver:

```
┌──────────────────────────────────────────────────────────┐
│  All workflows    Deploy to GitHub Pages                │
│                                                          │
│  Deploy to GitHub Pages                                 │
│  fix: Enable GitHub Pages deployment                    │
│                                                          │
│  🟡 In progress (está ejecutando)                       │
│     Ran 1 minute ago                                    │
│                                                          │
│     Checkout     ✅ 5 segundos                          │
│     Setup .NET   🟡 En progreso                         │
│     Restore      ⏳ En cola                             │
│     Build        ⏳ En cola                             │
│     Publish      ⏳ En cola                             │
│     Deploy       ⏳ En cola                             │
│                                                          │
│  Esperando a que se ponga 🟢 GREEN ✅                   │
│                                                          │
└──────────────────────────────────────────────────────────┘
```

**Espera 2-3 minutos a que todo sea verde ✅**

---

## PASO 10: Abre tu URL (Cuando esté todo verde)

```
https://qsiul1710-cloud.github.io/BlazorWasmApp/
```

Deberías ver:

```
┌──────────────────────────────────────────────────────────┐
│                                                          │
│                    🔒 Iniciar Sesión                    │
│                                                          │
│                  🛡️ [Icono de seguridad]                │
│                                                          │
│              Gestión de Lotes y Análisis                │
│                                                          │
│         Usuario:    [____________]                      │
│         Contraseña: [____________] 👁️                  │
│                                                          │
│         [  Autenticando...  ]                           │
│                                                          │
│         📝 Credenciales de Demostración:                │
│            Usuario: admin   |  Contraseña: admin123     │
│            Usuario: usuario | Contraseña: password123   │
│                                                          │
└──────────────────────────────────────────────────────────┘
```

**¡Tu app está ONLINE! 🎉**

---

## RESUMEN VISUAL

```
Visual Studio
	↓
Git → Changes
	↓
Click "+"
	↓
Escribe mensaje
	↓
Ctrl+Enter (Commit)
	↓
Git → Push (o Ctrl+Shift+P)
	↓
Espera 3 minutos
	↓
Tu app está online ✅
```

---

**¡Eso es TODO! Tu app está lista.** 🚀

