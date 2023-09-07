import { Section } from 'structs/navigation'

export const useNavigation = () => {
  const sections = useState<Section[]>('navigation', () => []);

  const addSection = (
    section: Section
  ) => {
    if (!section.id) { section.id = sections.value.length + 1; }

    sections.value.push(section);
  };

  const removeSection = (id: string|number) => {
    const index = sections.value.findIndex((section) => section.id === id);
    sections.value.splice(index, 1);
  }

  const clearAllSections = () => {
    sections.value = [];
  };

  return { sections, addSection, removeSection, clearAllSections };
};
