# Contributing to PrintSmartPro

Thank you for your interest in contributing to **PrintSmartPro**! Whether you are fixing a bug, adding support for new label templates or barcode formats, or improving documentation, your help is welcome.

---

## Core Principles

1. **Zero Telemetry & Offline-First:** PrintSmartPro runs 100% locally. Do not introduce analytics, tracking, or unnecessary network calls.
2. **Fast & Reliable Printing:** Warehouse and office workflows depend on predictable printing behavior. Always ensure batch print operations confirm before sending large print jobs to physical printers.
3. **Clean Dependencies:** Keep external dependencies minimal and well-maintained.

---

## Development Setup

1. **Prerequisites:**
   - Windows 10 or Windows 11
   - [Visual Studio 2022](https://visualstudio.microsoft.com/) with the **.NET desktop development** workload
   - .NET Framework 4.8 Developer Pack
2. **Clone & Build:**
   ```powershell
   git clone https://github.com/Creator-NL/PrintSmartPro.git
   cd PrintSmartPro
   ```
3. Open `PrintSmartPro.sln` in Visual Studio 2022, restore NuGet packages (`ZXing.Net`), and press `F5` or click **Build > Build Solution**.

---

## Submitting Changes

1. Fork the repository and create a feature branch from `main` (e.g., `feature/custom-label-size` or `fix/clipboard-import`).
2. Test your changes thoroughly (using **Microsoft Print to PDF** or a physical label printer).
3. Ensure no `bin/`, `obj/`, `.vs/`, or `.pfx` files are staged.
4. Open a Pull Request with a clear description of what changed and why.
