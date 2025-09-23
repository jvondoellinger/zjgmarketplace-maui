using Marketplace.Products.UI.ViewModel;
using System.Collections.Generic;
using zjgmarketplace.Modules.UI.Products.ViewModel;

namespace Marketplace.Products.UI.ViewModel.Test;
public class ProductModelTest
{
    public static List<PreviewProductViewModel> Load()
    {
        var list = new List<PreviewProductViewModel>();
        for (int i = 0; i < 10; i++)
        {
            list.Add(new PreviewProductViewModel()
            {
                Id = i.ToString(),
                ImageURL = "fallback.png",
                Price = decimal.Parse("123.11"),
                Title = "Test"
            });
        }
        return list;
    }

    public static ProductViewModel Load2()
    {
        return new ProductViewModel()
        {
            ImagesURL = ["fallback.png", "fallback.png", "fallback.png", "fallback.png"],
            Price = decimal.Parse("123.11"),
            Title = "Monitor Gamer SuperFrame Prisma V2, 27 Pol, Flat, Fast IPS, Quad HD, 0.3ms, 185Hz, 110% sRGB, FreeSync, Branco, HDMI/DP, SFPFW-27185-QHD-PRO",
            Description = "Aqui vai uma descrição detalhada (ideal pra uso em loja online ou catálogo) pro Monitor Gamer SuperFrame Prisma V2 — SFPFW‑27185‑QHD‑PRO:\r\n\r\nMonitor Gamer SuperFrame • Prisma V2 – 27″ QHD PRO\r\n\r\nDesperte seu potencial nos jogos com o SuperFrame Prisma V2, um monitor gamer premium projetado para oferecer velocidade, fidelidade de cores e imersão incríveis. Com construção elegante em branco, desempenho top de linha e recursos avançados, ele é ideal para gamers exigentes e criadores visuais.\r\n\r\n📏 Especificações Principais\r\nEspecificação\tDetalhes\r\nTamanho / Tipo de Tela\t27 polegadas, painel “Flat” (plano), Fast IPS\r\nResolução\tQuad HD (2560 × 1440) – imagem mais nítida vs Full HD\r\nTempo de Resposta\t0,3 ms (GtG ou propagação rápida) – redução de ghosting e borrões de movimento\r\nTaxa de Atualização\tAté 185 Hz – visual mais fluido, ideal para jogos competitivos\r\nCobertura de Cores\t~110% sRGB – cores vibrantes e precisão razoável para trabalhos gráficos ou criativos\r\nSuporte a Tecnologias\tFreeSync – para evitar screen tearing sincronizando GPU e monitor\r\nConectividade\tHDMI e DisplayPort – compatibilidade ampla com PCs, consoles, notebooks\r\nDesign & Acabamento\tCorpo branco, acabamento moderno, visual clean e elegante\r\n✨ Pontos de Destaque\r\n\r\nImagem fluida: 185 Hz + 0,3 ms garante que movimentos rápidos sejam renderizados de forma suave, ideal para games de tiro, plataforma ou ação intensa.\r\n\r\nCores realistas: com 110% sRGB, você tem mais fidelidade, bom para quem edita fotos/vídeos ou quer que o visual dos jogos fique “no ponto”.\r\n\r\nAlta resolução: QHD entrega mais clareza e espaço de trabalho, comparado ao Full HD.\r\n\r\nÓtima compatibilidade: DisplayPort e HDMI permitem usar com PCs modernos e consoles, e o FreeSync ajuda a manter tudo sincronizado.\r\n\r\nEstética premium: acabamento branco e design flat que combinam bem com setups modernos.\r\n\r\n⚠️ Possíveis Considerações\r\n\r\nSe você joga em ambientes muito escuros, painel branco pode refletir mais luz ambiente.\r\n\r\nPara tirar proveito de 185 Hz seu hardware (GPU+CPU) precisa ser capaz de manter altas frames por segundo em QHD.\r\n\r\nEmbora 110% sRGB seja bom, se você trabalha com cores profissionais (impressão, design gráfico extremo), talvez queira algo com cobertura AdobeRGB ou DCI‑P3 maiores."
        };
    }
}
