# Accessibility Statement for PrintSmartPro

**Biohazard Corp** is committed to making **PrintSmartPro** practical and accessible for keyboard and assistive-technology users on Windows.

## Supported Environments & Features

- **Platform:** Windows 10 and Windows 11 Desktop (Windows Forms / .NET Framework 4.8).
- **Keyboard Navigation:** Logical `TabIndex` ordering across the import button, search input, print type selector, printer selector, and barcode generator controls.
- **High Contrast & Legibility:** Uses crisp `Segoe UI` typography (with bold 12pt labels on generated barcodes) and high-contrast solid black-on-white barcode rendering.
- **Tooltips & Status Feedback:** Interactive controls provide descriptive tooltips and status bar messages (such as clipboard copy confirmation and search status).

## Known Limitations

- The barcode preview (`PictureBox`) displays a visual bitmap. Users can verify the encoded text value via the built-in **Decode** button, which outputs the decoded string into a standard readable text field (`TxtDecode`).
- Print templates (`PrintA4Barcode`, `PrintA4ProductManipulation`, `PrintZebraLabelBigGK420D`) render visual form bitmaps directly to the Windows print spooler.

## Reporting Accessibility Barriers

If you encounter an accessibility barrier in **PrintSmartPro**, please open an issue on GitHub or contact us at **contact@biohazard-corp.nl**.
