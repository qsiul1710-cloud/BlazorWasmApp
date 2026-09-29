#!/bin/bash

# Script para verificar deployment en GitHub Pages

echo "=== Verificando configuración de deployment ==="
echo ""

echo "1. Verificando rama actual..."
CURRENT_BRANCH=$(git rev-parse --abbrev-ref HEAD)
echo "   Rama actual: $CURRENT_BRANCH"
echo ""

echo "2. Verificando archivos críticos..."
if [ -f "wwwroot/.nojekyll" ]; then
	echo "   ✓ wwwroot/.nojekyll existe"
else
	echo "   ✗ wwwroot/.nojekyll NO existe"
fi

if [ -f ".github/workflows/deploy.yml" ]; then
	echo "   ✓ .github/workflows/deploy.yml existe"
else
	echo "   ✗ .github/workflows/deploy.yml NO existe"
fi

echo ""
echo "3. Verificando base href en index.html..."
grep 'base href' wwwroot/index.html || echo "   ✗ No se encontró base href"

echo ""
echo "4. Cambios pendientes:"
git status --short || echo "   Git no disponible"

echo ""
echo "=== Próximos pasos ==="
echo "1. Commit: git add . && git commit -m 'Fix: GitHub Pages deployment'"
echo "2. Push: git push origin $CURRENT_BRANCH"
echo "3. Verifica el workflow en: https://github.com/qsiul1710-cloud/BlazorWasmApp/actions"
