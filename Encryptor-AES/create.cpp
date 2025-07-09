#include <iostream>
#include <fstream>
#include <vector>
#include <string>
#include <windows.h>

std::string ReadFile(const std::string& path) {
    std::ifstream file(path, std::ios::in);
    if (!file) return "";
    std::string content((std::istreambuf_iterator<char>(file)), std::istreambuf_iterator<char>());
    return content;
}

void WriteSkidFile(const std::vector<std::string>& files, const std::string& outputPath) {
    std::ofstream output(outputPath, std::ios::out);
    if (!output) {
        std::cerr << "No se pudo escribir en " << outputPath << "\n";
        return;
    }

    for (const auto& file : files) {
        std::string content = ReadFile(file);

        int count = 0;
        for (char c : content) if (c == '\n') ++count;
        if (count > 5) {
            size_t last = content.find_last_of('\n');
            last = content.find_last_of('\n', last - 1); 
            content = content.substr(0, last);
        }

        output << "// BEGIN: " << file << "\n";
        output << content << "\n\n";
    }

    output << "// ERROR: fin de código incompleto...\n";
    output << "// Falta cerrar función o clase correctamente\n";

    output.close();
    MessageBoxA(0, "Archivo ensamblado: MasterSkidEdition.ps1", "¡Hecho!", MB_OK | MB_ICONINFORMATION);
}

int main() {
    std::vector<std::string> files = {
        "main_gui.ps1",
        "key_core.ps1",
        "file_ops.ps1",
        "aes_engine.cs",
        "finalizer.cs"
    };

    WriteSkidFile(files, "MasterSkidEdition.ps1");
    return 0;
}

// esto esta protegido para que no nos roben los skids ;)
