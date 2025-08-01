# OGMiner

![demo](/imgstore/demo.png)

Утилита для подсчёта выработки планет для браузерной игры OGame.

## Как вычисляется выработка в OGame

- Каждая планета имеет небольшое Естественное производство. Ресурсы вырабатываются за счёт естественного производства, даже если нет ни одной шахты
- Основную (базовую) часть ресурсов производят шахты: Рудник по добыче металла, Рудник по добыче кристалла и Синтезатор дейтерия. Все остальные бонусы вычисляются как процент от базовой выработки и затем просто складываются
- Энергия вырабатывается только Солнечными и Термоядерными электростанциями, а также Солнечными спутниками. Все остальные бонусы энергии вычисляются как процент, по аналогии с выработкой шахт (Роктальская Камера Разрыва НЕ вырабатывает энергию, а только уменьшает её потребление другими постройками и добавляет бонус к выработке)
- Все остальные бонусы (гусеничники, ускорители, бонусы от офицеров, бонусы класса и альянса, технологический бонус ФЖ) вычисляются как процент от базовой
- Выработка со всех планет складывается и получается общая выработка Империи

На выработку влияют:
- Скорость экономики (настройка сервера)
- Температура планеты (влияет на производительность синтезатора дейтерия)
- Позиция планеты (даёт дополнительные бонусы влияющие на базовую выработку шахт и естественное производство)